using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppelliEsami
{
    class Appello
    {
        public string NomeMateria { get; set; }
        public DateTime DataVerbalizzazione { get; set; }
        public Tipologia Modalità { get; set; }

        public Appello()
        {

        }

        public enum Tipologia
        {
            Scritto,
            Orale
        }

    }
}
