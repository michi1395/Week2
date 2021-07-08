using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class Conto
    {
        public string Intestatario { get; set; }
        public int NumeroConto { get; set; }
        public double Saldo { get; set; }
        public Tipologia TipoDiConto { get; set; }


        public Conto()
        {

        }

        public Conto(string intestatario, Tipologia tipoConto)
        {
            Intestatario = intestatario;
            TipoDiConto = tipoConto;
            Saldo = 100;
        }

        public enum Tipologia
        {
            Corrente,
            Risparmio
        }

        public void AggiornaSaldo(double versamento)
        {
           Saldo = Saldo + versamento;
        }

 
    }
}
