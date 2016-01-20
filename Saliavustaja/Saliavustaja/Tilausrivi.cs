using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saliavustaja
{
    class Tilausrivi
    {
        // Luokka jossa säilytetään tilausrivin tiedot
        public string tuote;
        public double ahinta;
        public int maara;

        public Tilausrivi(string ptuote, double pahinta, int pmaara)
        {
            tuote = ptuote;
            ahinta = pahinta;
            maara = pmaara;
        }
    }
}
