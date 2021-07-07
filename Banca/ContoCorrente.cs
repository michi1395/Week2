using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class ContoCorrente
    {
        public string Intestatatrio { get; set; }
        public string NumeroConto { get; set; }
        public double Saldo { get; set; }
        public Tipologia TipoDiConto { get; set; }


        public ContoCorrente()
        {

        }

        public enum Tipologia
        {
            Corrente,
            Risparmio
        }
    }
}
