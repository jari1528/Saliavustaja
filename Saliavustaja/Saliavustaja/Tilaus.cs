using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// tiedostonhallinta vaatii seuraavat
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
// DEBUG
using System.Windows.Forms;

namespace Saliavustaja
{
    [Serializable()]
    class Tilaus
    {
        // Luokka jossa säilytetään tilauksen tiedot, 
        // sekä tilauksen käsittelyyn liittyvät yleiset metodit

        //tilauksen tiedot
        protected int tilausnro;
        public string poyta;
        protected double loppusumma;
        protected double loppusummaveroton;
        protected double loppusummanvero;
        protected DateTime aikaleima;

        private const double verokerroin = 1.14;

        // getterit
        public int Tilausnro
        {
            get { return tilausnro; }
        }

        public double Loppusumma
        {
            get { return loppusumma; }
        }

        public double LoppusummaVeroton
        {
            get { return loppusummaveroton; }
        }

        public double LoppusummanVero
        {
            get { return loppusummanvero; }
        }

        public DateTime Aikaleima
        {
            get { return aikaleima; }
        }

        // tilausrivit
        public List<Tilausrivi> tilausrivit;

        // oletusmuodostin
        public Tilaus()
        {
            // tilauksen tilausrivit instanssi
            tilausrivit = new List<Tilausrivi>();
        }

        // tallennetaan uusi tilaus tilauskantaan
        // tarkistaa automaattisesti suurimman seuraavan vapaan tilausnumeron
        public void TallennaTilaus(List<Tilaus> ptilaukset, Tilaus uusitilaus)
        {
            //apumuuttuja
            double loppusumma = 0;

            uusitilaus.tilausnro = VapaaTilausnumero(ptilaukset);

            // lasketaan loppusumma
            for (int i = 0; i < uusitilaus.tilausrivit.Count; i++)
            {
                //loppusummaan lisätään tilausrivin a-hinta kertaa tilausrivin määrä
                loppusumma = loppusumma + (uusitilaus.tilausrivit[i].ahinta * uusitilaus.tilausrivit[i].maara);
            }
            // loppusumma tilaukselle kahdella desimaalilla
            uusitilaus.loppusumma = Math.Round(loppusumma, 2);

            // lasketaan veroton summa kahdella desimaalilla
            uusitilaus.loppusummaveroton = Math.Round(uusitilaus.loppusumma / verokerroin, 2);

            // veron osuus, verollinen miinus veroton
            uusitilaus.loppusummanvero = uusitilaus.loppusumma - uusitilaus.loppusummaveroton;

            // haetaan aikaleima tilaukselle
            aikaleima = DateTime.Now;

            // lisätään tilauslistaan
            ptilaukset.Add(uusitilaus);
        }

        // metodi palauttaa suurimman vapaan tilausnumeron tilauslistalta
        private int VapaaTilausnumero(List<Tilaus> ptilaukset)
        {
            // apumuuttuja asetetaan aluksi nollaksi
            int suurintilausnro = 0;

            // käydään tilauslistan tilausnumerot läpi
            for (int i = 0; i < ptilaukset.Count; i++)
            {
                //jos tarkasteltava numero on suurempi kuin apumuuttuja
                //korvataan apumuuttujan arvo
                if (ptilaukset[i].tilausnro > suurintilausnro)
                {
                    suurintilausnro = ptilaukset[i].tilausnro;
                }
            }
            // palauttaa listan suurimman tilausnumeron + 1 eli seuraava vapaa
            return suurintilausnro + 1;
        }

        // tilauskannan tallennus tiedostoon. palauttaa false jos tulee virhe.
        public bool TallennaTilauskanta(List<Tilaus> ptilaukset, string tiedostonimi)
        {
            try
            {
                using (Stream tiedosto = File.Open(tiedostonimi, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(tiedosto, ptilaukset);
                }
                // jos kirjoitus onnistuu, palautetaan true
                return true;
            }
            // jos tiedostovirhe, palautetaan false
            catch (IOException)
            {
                return false;
            }
            // jos datassa on virhe, palautetaan false
            catch (SerializationException)
            {
                MessageBox.Show("Serialization...", "Virhe!");
                return false;
            }
        }
    }
}
