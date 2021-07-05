using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interessi
{
    class CalcoloInteressi
    {
        public static void Start()
        {
            decimal value = CalcoloValoreIterativo();
            Console.WriteLine($"Il valore complessivo è: {value}");

        }

        //static decimal CalcoloValoreRicorsivo()
        //{

        //}
        static decimal CalcoloValoreIterativo()
        {
            Console.WriteLine("Inserisci importo di denaro iniziale:");
            decimal sommaDenaro = CheckNum();
            Console.WriteLine("Per quanti anni vuoi veicolare?");
            int anni = CheckNum();

            for (int i=0;i<anni; i++)
            {
                sommaDenaro = sommaDenaro + ((sommaDenaro * anni) / 100);
            }
            return sommaDenaro;
        }
        static int CheckNum()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Puoi inserire solo numeri! Riprova:");
            }

            return num;

        }
    }
}
