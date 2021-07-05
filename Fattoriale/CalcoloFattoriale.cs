using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fattoriale
{
    class CalcoloFattoriale
    {
        public static void Start()
        {
            int numeroDaCalcolare = 5;
            FattorialeIterazione(numeroDaCalcolare);

            FattorialeRicorsione(numeroDaCalcolare);
        }
        static void FattorialeIterazione(int numero)
        {
            Console.WriteLine("Sto calcolando con l'iterazione");
            int totale = 1;
            for(int i=numero;i>0;i--)
            {
                Console.WriteLine($"Il valore di i è{i}");
                totale = totale * i;
                Console.WriteLine($"Il totale provvisorio è {totale}");
            }
            Console.WriteLine($"Il fattoriale di {numero} è {totale}");
        }

        static int FattorialeRicorsione(int numero)
        {
            int totale = 1;
            Console.WriteLine($"Il valore del numero da calcolare è {numero}");
            if(numero>1)
            { 
                totale = numero * FattorialeRicorsione(numero - 1);
                Console.WriteLine($"Il totale provvisorio è {totale}");
            }
            Console.WriteLine($"Il fattoriale di {numero} è {totale}");
            return totale;
        }
    }
}
