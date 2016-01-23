using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.IO;

namespace Saliavustaja
{
    public partial class Saliavustaja : Form
    {
        //muistissa:
        //testing
        //string[] uusirivi = new string[] { "Erkki esimerkki", "13.45", "2" };
        //TilausRivit.Rows.Add(uusirivi);

        // ohjelman nimivakio
        const string ohjelmanNimi = "Saliavustaja (v0.6)";

        //tilauskantatiedoston nimi
        const string tietokanta = "tiedosto.db";

        // yleisinstanssi tilausmetodien kutsumiseen
        Tilaus tilaushallinta = new Tilaus();

        // tilaustietokanta lista
        List<Tilaus> tilauskanta = new List<Tilaus>();

        // muuttuja onko tilaus kesken
        bool TilausKesken;


        public Saliavustaja()
        {
            InitializeComponent();
        }


        // metodi suoritetaan kun ohjelma avautuu
        private void Saliavustaja_Load(object sender, EventArgs e)
        {
            // ikkunan otsikko
            this.Text = ohjelmanNimi;

            // ohjelman avauksessa ei ole uutta tilausta auki
            TilausKesken = false;
            TyhjennaTilaus();
            OhjelmanTila();

            // jos tietokantatiedosto löytyy niin yritetään ladata
            if (File.Exists(tietokanta))
            {
                // tietokannan lataus, jos virhe niin lopetetaan ohjelma
                if ((tilaushallinta.LataaTilauskanta(tilauskanta, tietokanta)) == false)
                {
                    MessageBox.Show(Path.GetFullPath(tietokanta) +
                    "\nLoading database failed, exiting!", "Error");
                    this.Close();
                }
            }           
        }

        // muuttaa painikkeiden ja elementtien tilan bool TilausKesken mukaisesti
        private void OhjelmanTila()
        {
            if (TilausKesken == false)
            {
                UusiTilausButton.Enabled = true;
                LisaaRiviButton.Enabled = false;
                PoistaRiviButton.Enabled = false;
                PeruTilausButton.Enabled = false;
                LisaaTilausButton.Enabled = false;

                this.Text = ohjelmanNimi;
            }
            else if (TilausKesken == true)
            {
                UusiTilausButton.Enabled = false;
                LisaaRiviButton.Enabled = true;
                PoistaRiviButton.Enabled = true;
                PeruTilausButton.Enabled = true;
                LisaaTilausButton.Enabled = true;

                this.Text = ohjelmanNimi + " - UUSI TILAUS";
            }
        }

        // ********* omat metodit ************
    
        // tyhjentää tilauksen tiedot
        private void TyhjennaTilaus()
        {
            ValitsePoytaValikko.Text = "";
            TilausVeroLabel.Text = "";
            TilausVerotonLabel.Text = "";
            TilausSummaLabel.Text = "";

            TilausRivitLtk.Rows.Clear();
            //TilausRivitLtk.Refresh();
        }

        // tilauksen peruminen, palauttaa bool peruttiinko tilaus
        private bool PeruTilaus(string pteksti)
        {
            if(TilausKesken == true)
            {
                DialogResult perutaankoTilaus = MessageBox.Show(
                    pteksti,"Tilauksen peruminen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);
                if(perutaankoTilaus == DialogResult.Yes)
                { 
                    TilausKesken = false;
                    TyhjennaTilaus();
                    OhjelmanTila();
                    return true;
                }
            }
            return false;
        }


        // ***** painikkeet ********


        // uuden tilauksen aloitus painike
        private void UusiTilausButton_Click(object sender, EventArgs e)
        {
            if (TilausKesken == false)
            {
                TilausKesken = true;
                TyhjennaTilaus();
                OhjelmanTila();
            }    
         }

        // Rivin lisääminen tilaukselle painike
        private void LisaaRiviButton_Click(object sender, EventArgs e)
        {
            // tarkistetaan onko yhtään riviä valittu
            if (RuokalistaLtk.SelectedItems.Count == 1)
            {
                // Lisää menusta valitun rivin tilausriviksi määrällä 1
                int uusirivi = TilausRivitLtk.Rows.Add(RuokalistaLtk.SelectedItems[0].Text,
                    RuokalistaLtk.SelectedItems[0].SubItems[1].Text, 1);

                // valitaan juuri lisätyn rivin määrä solu
                TilausRivitLtk.CurrentCell = TilausRivitLtk.Rows[uusirivi].Cells[2];

                // vaihdetaan focus tilausrivilaatikkoon
                TilausRivitLtk.Focus();
            }

        }

        // Rivin poistaminen tilaukselta
        private void PoistaRiviButton_Click(object sender, EventArgs e)
        {
            // tarkistetaan onko solua valittu
            if(TilausRivitLtk.SelectedCells.Count == 1)
            {
                TilausRivitLtk.Rows.RemoveAt(TilausRivitLtk.CurrentCell.RowIndex);
            }
        }

        // painike tilauksen perumiselle
        private void PeruTilausButton_Click(object sender, EventArgs e)
        {
            if (TilausKesken == true)
            {
                // kutsutaan tilauksen perumismetodia
                bool peruttiinkoTilaus = PeruTilaus("Perutaanko tilaus, tiedot menetetään?");

                // debug logiikkaa
                if (peruttiinkoTilaus == true)
                {
                    //MessageBox.Show("Tilaus peruttiin", "Tiedoksi");
                }
                else if (peruttiinkoTilaus == false)
                {
                    // MessageBox.Show("Tilausta ei peruttu", "Tiedoksi");
                }
            }
        }

        // tilauksen tallennus tilauskantaan
        private void LisaaTilausButton_Click(object sender, EventArgs e)
        {
            // TODO
        }


        // **** ohjelman sulkeminen ****

        // painettu ruksia ikkunan sulkemiseksi, tarkistetaan onko tilaus kesken
        private void Saliavustaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TilausKesken == true)
            {
                // kutsutaan tilauksen perumismetodia
                bool peruttiinkoTilaus = PeruTilaus(
                    "Ohjelmaa suljetaan, sinulla on tallentamaton tilaus.\n" 
                    + "Perutaanko tilaus, tiedot menetetään?");

                // debug logiikkaa
                if (peruttiinkoTilaus == true)
                {
                    //MessageBox.Show("Tilaus peruttiin", "Tiedoksi");
                }
                else if (peruttiinkoTilaus == false)
                {
                    //MessageBox.Show("Tilausta ei peruttu", "Tiedoksi");

                    // jos käyttäjä painaa dialogissa No, perutaan sulkeminen
                    e.Cancel = true;
                }
            }
        }

        // Tallennetaan tietokanta kun ohjelma sulkeutuu
        private void Saliavustaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show(Path.GetFullPath(tietokanta) + "\nTietokannan tallennus...", "Tiedoksi");
        }

    


        // *** tarpeettomat ***
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RuokalistaLaatikko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}