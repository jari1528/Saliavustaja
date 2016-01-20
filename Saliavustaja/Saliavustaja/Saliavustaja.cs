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

        public Saliavustaja()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RuokalistaLaatikko_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
