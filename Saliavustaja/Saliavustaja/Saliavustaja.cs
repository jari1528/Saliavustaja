using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// added
using System.IO;

namespace Saliavustaja
{
    public partial class Saliavustaja : Form
    {
        //muistissa:
        //testing
        //string[] uusirivi = new string[] { "Erkki esimerkki", "13.45", "2" };
        //TilausRivit.Rows.Add(uusirivi);

        // ohjelman nimi vakio
        const string ohjelmanNimi = "Saliavustaja (v0.5)";

        //tilauskantatiedoston nimi
        const string tietokanta = "tiedosto.db";

        // yleisinstanssi tilausmetodien kutsumiseen
        Tilaus tilaushallinta = new Tilaus();

        // tilaustietokanta
        List<Tilaus> tilauskanta = new List<Tilaus>();

        // muuttuja ohjelman tilan tarkistamiseen
        bool TilausKesken;


        public Saliavustaja()
        {
            InitializeComponent();
        }

        // metodi suoritetaan kun ikkuna avautuu
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

        // tarpeettomat --->
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RuokalistaLaatikko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // <--- tarpeettomat

        // muuttaa painikkeiden ja elementtien tilan TilausKesken mukaisesti
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

        // tyhjentää tilauksen tiedot
        private void TyhjennaTilaus()
        {
            ValitsePoytaValikko.Text = "";
            TilausVeroLabel.Text = "";
            TilausVerotonLabel.Text = "";
            TilausSummaLabel.Text = "";
            //TilausRivitLtk;
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

        private void UusiTilausButton_Click(object sender, EventArgs e)
        {
            // jos tilaus jo kesken, button ei tee mitään
            if (TilausKesken == false)
            {
                TilausKesken = true;
                TyhjennaTilaus();
                OhjelmanTila();
            }    
        }

        private void PeruTilausButton_Click(object sender, EventArgs e)
        {
            if (TilausKesken == true)
            {
                bool peruttiinkoTilaus = PeruTilaus("Perutaanko tilaus, tiedot menetetään?");

                // debug logiikkaa
                if (peruttiinkoTilaus == true)
                {
                    MessageBox.Show("Tilaus peruttiin", "Tiedoksi");
                }
                else if (peruttiinkoTilaus == false)
                {
                    // MessageBox.Show("Tilausta ei peruttu", "Tiedoksi");
                }
            }
        }

        private void Saliavustaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TilausKesken == true)
            {
                bool peruttiinkoTilaus = PeruTilaus(
                    "Ohjelmaa suljetaan, sinulla on tallentamaton tilaus.\n" 
                    + "Perutaanko tilaus, tiedot menetetään?");

                // debug logiikkaa
                if (peruttiinkoTilaus == true)
                {
                    MessageBox.Show("Tilaus peruttiin", "Tiedoksi");
                }
                else if (peruttiinkoTilaus == false)
                {
                    MessageBox.Show("Tilausta ei peruttu", "Tiedoksi");
                    e.Cancel = true;
                }
            }
        }

        private void Saliavustaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(Path.GetFullPath(tietokanta) + "\nTietokannan tallennus...", "Tiedoksi");
        }
    }
}