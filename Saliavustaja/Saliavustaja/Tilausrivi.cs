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
        public double maara;

        // oletusmuodostin, alustaa tyhjillä arvoilla
        public Tilausrivi()
        {
            tuote = "";
            ahinta = 0;
            maara = 0;
        }

        // muodostin, alustaa parametrien arvoilla
        public Tilausrivi(string ptuote, double pahinta, double pmaara)
        {
            tuote = ptuote;
            ahinta = pahinta;
            maara = pmaara;
        }
    }
}
