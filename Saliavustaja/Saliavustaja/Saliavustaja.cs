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
        // ****** vakiot ********
        // ohjelman nimivakio
        const string ohjelmanNimi = "Saliavustaja (v0.9.5)";

        //tilauskantatiedoston nimi
        const string tietokanta = "tiedosto.db";

        // ALV kerroin
        const double verokerroin = 1.14;


        // **** instanssit *****

        // yleisinstanssi tilausmetodien kutsumiseen
        //Tilaus tilaushallinta = new Tilaus();

        // tilaustietokanta lista
        List<Tilaus> tilauskanta = new List<Tilaus>();

        // muuttuja onko tilaus kesken
        bool TilausKesken;


        // *** alustus ****

        // oletusmuodostin
        public Saliavustaja()
        {
            InitializeComponent();
        }

        // metodi suoritetaan kun ohjelma avautuu
        private void Saliavustaja_Load(object sender, EventArgs e)
        {
            // instanssi jotta voidaan kutsua Tilaus luokan metodia
            Tilaus tilaushallinta = new Tilaus();

            // ikkunan otsikko
            this.Text = ohjelmanNimi;

            // ohjelman avauksessa ei ole uutta tilausta auki
            TilausKesken = false;
            TyhjennaTilaus();
            OhjelmanTila();

            // jos tietokantatiedosto löytyy niin yritetään ladata
            if (File.Exists(tietokanta))
            {
                // tietokannan lataus, jos virhe niin lopetetaan ohjelma heti
                if ((tilaushallinta.LataaTilauskanta(tilauskanta, tietokanta)) == false)
                {
                    MessageBox.Show(Path.GetFullPath(tietokanta) +
                    "\nLoading database failed, exiting!", "Error");
                    this.Close();
                }
            }

            // tilauslista refresh
            TilauksetRefresh();
            // tilauslista selection pois
            TilauksetLtk.ClearSelection();
        }


        // ********* omat metodit ************


        // muuttaa painikkeiden ja elementtien tilan bool TilausKesken mukaisesti
        private void OhjelmanTila()
        {
            if (TilausKesken == false)
            {
                // muutetaan nappien tiloja
                UusiTilausButton.Enabled = true;
                LisaaRiviButton.Enabled = false;
                PoistaRiviButton.Enabled = false;
                PeruTilausButton.Enabled = false;
                LisaaTilausButton.Enabled = false;

                // muutetaan ikkunan otsikkoa
                this.Text = ohjelmanNimi;
            }
            else if (TilausKesken == true)
            {
                // muutetaan nappien tiloja
                UusiTilausButton.Enabled = false;
                LisaaRiviButton.Enabled = true;
                PoistaRiviButton.Enabled = true;
                PeruTilausButton.Enabled = true;
                LisaaTilausButton.Enabled = true;

                // muutetaan ikkunan otsikkoa
                this.Text = ohjelmanNimi + " - *** UUSI TILAUS ***";
            }
        }


        // tyhjentää tilauksen tiedot
        private void TyhjennaTilaus()
        {
            ValitsePoytaValikko.Text = "";
            TilausVeroLabel.Text = "";
            TilausVerotonLabel.Text = "";
            TilausSummaLabel.Text = "";

            // tyhjentää tilausrivit datagridview laatikon
            TilausRivitLtk.Rows.Clear();
            TilausRivitLtk.ReadOnly = false;
        }

        // tilauslista laatikon refresh
        private void TilauksetRefresh()
        {
            // tyhjentää laatikon rivit
            TilauksetLtk.Rows.Clear();

            // lisätään tilauskannan kaikki tilaukset listaan
            for (int i = 0; i < tilauskanta.Count; i++)
            {
                TilauksetLtk.Rows.Add(tilauskanta[i].Tilausnro, tilauskanta[i].poyta, tilauskanta[i].Aikaleima,
                                      tilauskanta[i].Loppusumma.ToString("0.00") + " €");
            }

            // sortataan lista uusin ylös
            TilauksetLtk.Sort(TilauksetLtk.Columns[0], ListSortDirection.Descending);
        }


        // tilauksen peruminen, palauttaa bool peruttiinko tilaus
        private bool PeruTilaus(string pteksti)
        {
            if (TilausKesken == true)
            {
                // kysytään dialogilla varmistus Yes / No
                DialogResult perutaankoTilaus = MessageBox.Show(
                    pteksti, "Tilauksen peruminen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                // jos vastattiin Yes, perutaan
                if (perutaankoTilaus == DialogResult.Yes)
                {
                    TilausKesken = false;
                    TyhjennaTilaus();
                    OhjelmanTila();
                    return true;
                }
            }

            // ei peruttu, palautetaan false
            return false;
        }


        // palauttaa false jos laskennassa ongelma, esim. lukujen muutos ei onnistu
        // HUOM! laskee summat vain käyttöliittymään tilauksen ollessa kesken,
        // tilauksen tallennuksessa lasketaan summat uudelleen.
        private bool LaskeTilauksenSummat()
        {
            //apumuuttujat
            double loppusumma = 0;
            double loppusummaveroton = 0;
            double ahinta = 0;
            double maara = 0;

            // lasketaan loppusumma
            for (int i = 0; i < TilausRivitLtk.Rows.Count; i++)
            {
                // haetaan ahinta laatikosta, muunnetaan teksti luvuksi
                if (Double.TryParse(TilausRivitLtk.Rows[i].Cells[1].Value.ToString(), out ahinta) == false)
                {
                    // jos lukumuunnoksessa virhe, palautetaan heti false
                    return false;
                }

                // haetaan määrä laatikosta, muunnetaan teksti luvuksi
                if (Double.TryParse(TilausRivitLtk.Rows[i].Cells[2].Value.ToString(), out maara) == false)
                {
                    // jos lukumuunnoksessa virhe, palautetaan heti false false
                    return false;
                }

                // loppusummaan lisätään tilausrivin a-hinta kertaa tilausrivin määrä
                loppusumma = loppusumma + (ahinta * maara);
            }
            // loppusumma kahdelle desimaalille
            loppusumma = Math.Round(loppusumma, 2);
            TilausSummaLabel.Text = loppusumma.ToString("0.00") + " €";

            // lasketaan veroton summa kahdella desimaalilla
            loppusummaveroton = Math.Round(loppusumma / verokerroin, 2);
            TilausVerotonLabel.Text = loppusummaveroton.ToString("0.00") + " €";

            // veron osuus, verollinen miinus veroton
            TilausVeroLabel.Text = (loppusumma - loppusummaveroton).ToString("0.00") + " €";

            // palautetaan true jos kaikki ok
            return true;
        }

        // muuntaa tilausrivit laatikosta Tilaus objektiin
        private bool MuunnaTilausRivit(Tilaus ptilaus)
        {
            if (TilausKesken == true)
            {
                // muunnetaan rivit
                for (int i = 0; i < TilausRivitLtk.Rows.Count; i++)
                {
                    // apumuuttujat, vain loopissa olemassa
                    double ahinta = 0;
                    double maara = 0;

                    // muodostetaan instanssi uudelle riville
                    Tilausrivi uusirivi = new Tilausrivi();


                    // haetaan ahinta laatikosta, muunnetaan teksti luvuksi apumuuttujaan
                    if (Double.TryParse(TilausRivitLtk.Rows[i].Cells[1].Value.ToString(), out ahinta) == false)
                    {
                        // jos lukumuunnoksessa virhe, palautetaan heti false
                        return false;
                    }

                    // haetaan määrä laatikosta, muunnetaan teksti luvuksi apumuuttujaan
                    if (Double.TryParse(TilausRivitLtk.Rows[i].Cells[2].Value.ToString(), out maara) == false)
                    {
                        // jos lukumuunnoksessa virhe, palautetaan heti false
                        return false;
                    }

                    // asetetaan arvot rivi objektiin
                    uusirivi.tuote = TilausRivitLtk.Rows[i].Cells[0].Value.ToString();
                    uusirivi.ahinta = ahinta;
                    uusirivi.maara = maara;

                    // lisätään uusi rivi tilaukselle
                    ptilaus.tilausrivit.Add(uusirivi);
                }

                // muunnos onnistui
                return true;
            }

            // ei tehty mitään, palautetaan false
            return false;
        }

        // palauttaa pyydetyn tilausnumeron indeksin tilauskannasta tai -1 jos tilausta ei löydy
        private int EtsiTilausKannasta(int ptilausnro)
        {
            // apumuuttujat
            int kantaindeksi = -1;
            int i = 0;

            while (i < tilauskanta.Count && kantaindeksi == -1)
            {
                if (tilauskanta[i].Tilausnro == ptilausnro)
                {
                    kantaindeksi = i;
                }
                else i++;
            }
            // jos while loop ei löydä tilausta niin palautuu vakioarvo -1
            return kantaindeksi;
        }

        // lataa valitun tilauksen tiedot kannasta, palauttaa false jos tilausta ei löydy
        private bool LataaTilauksenTiedot(int ptilausnro)
        {
            // apumuuttujat
            int kantaindeksi;

            kantaindeksi = EtsiTilausKannasta(ptilausnro);
            if (kantaindeksi == -1)
            {
                return false;
            }
            else
            {
                // ikkunan otsikko tilausnumerolla
                this.Text = ohjelmanNimi + " - Tilaus " + tilauskanta[kantaindeksi].Tilausnro;

                // loppusumma kannasta
                TilausSummaLabel.Text = tilauskanta[kantaindeksi].Loppusumma.ToString("0.00") + " €";

                // veroton summa kannasta
                TilausVerotonLabel.Text = tilauskanta[kantaindeksi].LoppusummaVeroton.ToString("0.00") + " €";

                // veron osuus kannasta
                TilausVeroLabel.Text = tilauskanta[kantaindeksi].LoppusummanVero.ToString("0.00") + " €";

                // asetetaan tilausrivit readonly
                TilausRivitLtk.ReadOnly = true;

                // tilausrivit kannasta
                for (int i = 0; i < tilauskanta[kantaindeksi].tilausrivit.Count; i++)
                {
                    TilausRivitLtk.Rows.Add(tilauskanta[kantaindeksi].tilausrivit[i].tuote, 
                                            tilauskanta[kantaindeksi].tilausrivit[i].ahinta.ToString("0.00"),
                                            tilauskanta[kantaindeksi].tilausrivit[i].maara.ToString());                
                }
            }
            return true;
        }


        // ***** painikkeet ********


        // uuden tilauksen aloitus painike
        private void UusiTilausButton_Click(object sender, EventArgs e)
        {
            if (TilausKesken == false)
            {
                // tilauslista selection pois
                TilauksetLtk.ClearSelection();

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
                bool peruttiinkoTilaus = PeruTilaus("Perutaanko tilaus?");

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
            if(TilausKesken == true)
            {
                // instanssi tilaukselle
                Tilaus uusitilaus = new Tilaus();

                if(MuunnaTilausRivit(uusitilaus) == false)
                {
                    MessageBox.Show("Loppusummaa ei voitu laskea\nTarkista rivit!", "Virhe!");

                    // jos virhe, palataan metodista heti
                    return;
                }

                // tarkistetaan että on valittu pöytä
                if (ValitsePoytaValikko.Text == "")
                {
                    MessageBox.Show("Pöytää ei ole valittu!", "Virhe!");

                    // jos virhe, palataan metodista heti
                    return;
                }
                else uusitilaus.poyta = ValitsePoytaValikko.Text;

                // tallennetaan tilaus tilauskantaan
                uusitilaus.TallennaTilaus(tilauskanta, uusitilaus);

                // refresh tilauslista
                TilauksetRefresh();
                // tilauslistan selection pois
                TilauksetLtk.ClearSelection();

                // tyhjennetään tilausrivit
                TilausKesken = false;
                TyhjennaTilaus();
                OhjelmanTila();
            }
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
                    + "Perutaanko tilaus?");

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

    
        // ***** näkymien päivitys *****

        // tilausrivit, jos solua muutettu, lasketaan summat uudelleen
        private void TilausRivitLtk_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // lasketaan summat  vain jos tilaus on kesken
            if (TilausKesken == true)
            {
                if(LaskeTilauksenSummat() == false)
                {
                    MessageBox.Show("Loppusummaa ei voitu laskea\nTarkista rivit!", "Virhe!");
                }
            }
        }

        // tilausrivit, jos rivi lisätty, lasketaan summat uudelleen
        private void TilausRivitLtk_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // lasketaan summat  vain jos tilaus on kesken
            if (TilausKesken == true)
            {
                if (LaskeTilauksenSummat() == false)
                {
                    MessageBox.Show("Loppusummaa ei voitu laskea\nTarkista rivit!", "Virhe!");
                }
            }
        }

        // tilausrivit, jos rivi poistettu, lasketaan summat uudelleen
        private void TilausRivitLtk_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // lasketaan summat  vain jos tilaus on kesken
            if (TilausKesken == true)
            {
                if (LaskeTilauksenSummat() == false)
                {
                    MessageBox.Show("Loppusummaa ei voitu laskea\nTarkista rivit!", "Virhe!");
                }
            }
        }

        // kun valitaan tilauslistalta jokin rivi
        private void TilauksetLtk_SelectionChanged(object sender, EventArgs e)
        {
            // jos tilausta ei kesken niin ladataan valitun tilauksen tiedot
            if(TilausKesken == false)
            {
                // apumuuttuja
                int tilausnro = 0;

                TyhjennaTilaus();

                //onko yksi rivi valittu
                if (TilauksetLtk.SelectedRows.Count == 1)
                {
                    //MessageBox.Show(TilauksetLtk.SelectedRows[0].Cells[0].Value.ToString(), "DEBUG");

                    if (Int32.TryParse(TilauksetLtk.SelectedRows[0].Cells[0].Value.ToString(), out tilausnro) == false)
                    {
                        // jos lukumuunnoksessa virhe, annetaan virhe ja palataan metodista heti
                        MessageBox.Show("Virhe tilausnumerossa", "Virhe!");
                        return;
                    }

                    if (LataaTilauksenTiedot(tilausnro) == false)
                    {
                        MessageBox.Show("Tilausta ei löydy tilauskannasta", "Virhe!");
                        return;
                    }
                }
            }
            // jos tilaus on kesken niin tyhjennetään valinta
            else
            {
                //MessageBox.Show("Tilaus kesken!", "Virhe!");
                TilauksetLtk.ClearSelection();
            }          
        }


        // *** tarpeettomat ***

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RuokalistaLaatikko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TilausRivitLtk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // **** 

    }
}