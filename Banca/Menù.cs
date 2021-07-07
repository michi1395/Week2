using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca
{
    class Menù
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto nella tua BANCA!\n");
            int scelta = 0;
            do
            {
                Console.WriteLine("Premi 1 per inserire un nuovo conto");
                Console.WriteLine("Premi 2 per elimare un conto");
                Console.WriteLine("Premi 3 per visualizzare conti presenti");

                Console.WriteLine("Premi 0 se hai terminato!");

                
                bool isInt = true;

                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                    if(!isInt)
                    {
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                    }
                } while (!isInt);

                switch (scelta)
                {
                    case 1:
                        AzioniUtente.CreaNuovoConto();
                        break;
                    case 2:
                        AzioniUtente.EliminaConto();
                        break;
                    case 3:
                        AzioniUtente.StampaConti();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                        break;

                }
            } while (scelta!=0);
        }
    }
}
