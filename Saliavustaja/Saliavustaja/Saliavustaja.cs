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
        //tilauskantatiedoston nimi
        const string tietokanta = "tiedosto.db";

        // yleisinstanssi tilausmetodien kutsumiseen
        Tilaushallinta tilaushallinta = new Tilaushallinta();

        // tilaustietokanta
        List<Tilaus> tilauskanta = new List<Tilaus>();

        bool TilausKesken;

        public Saliavustaja()
        {
            InitializeComponent();
        }

        // metodi suoritetaan kun ikkuna avautuu
        private void Saliavustaja_Load(object sender, EventArgs e)
        {
            // ohjelman avauksessa ei ole uutta tilausta auki
            TilausKesken = false;
            TarkistaTila();

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

        private void TarkistaTila()
        {
            if (TilausKesken == false)
            {
                LisaaRiviButton.Enabled = false;
                PoistaRiviButton.Enabled = false;
                PeruTilausButton.Enabled = false;
                LisaaTilausButton.Enabled = false;
            }
            else if (TilausKesken == true)
            {
                LisaaRiviButton.Enabled = true;
                PoistaRiviButton.Enabled = true;
                PeruTilausButton.Enabled = true;
                LisaaTilausButton.Enabled = true;
            }
        }

        private void UusiTilausButton_Click(object sender, EventArgs e)
        {
            // jos tilaus jo kesken, button ei tee mitään
            if (TilausKesken == false)
            {
                TilausKesken = true;
                TarkistaTila();
            }
            else if (TilausKesken == true)
            {
                TilausKesken = false;
                TarkistaTila();
            }

            //testing
            //string[] uusirivi = new string[] { "Erkki esimerkki", "13.45", "2" };
            //TilausRivit.Rows.Add(uusirivi);
        }
    }
}
