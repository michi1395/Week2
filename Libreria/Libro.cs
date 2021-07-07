using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public Tipologia Genere { get; set; }
        public double Prezzo { get; set; }

        //Costruttore
        public Libro()
        {

        }

        public enum Tipologia
        { 
            Narrativa,
            Storico,
            Fantasy
        }
    }
}
