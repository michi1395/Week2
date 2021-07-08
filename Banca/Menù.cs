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
            Console.WriteLine("Benvenuto nella tua BANCA!");
            int scelta = 0;
            do
            {
                Console.WriteLine("\nPremi 1 per Inserire un nuovo conto");
                Console.WriteLine("Premi 2 per Elimare un conto");
                Console.WriteLine("Premi 3 per Visualizzare i conti presenti all'interno della banca");
                Console.WriteLine("Premi 4 per Cercare i conti per tipo");
                Console.WriteLine("Premi 5 per Effettuare un prelievo");
                Console.WriteLine("Premi 6 per Effettuare un versamento");
                Console.WriteLine("Premi 7 per Salvare i dati su file");

                Console.WriteLine("Premi 0 per Uscire");

                
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
                        BancaManager.CreaNuovoConto();
                        break;
                    case 2:
                        BancaManager.EliminaConto();
                        break;
                    case 3:
                        BancaManager.StampaConti();
                        break;
                    case 4:
                        BancaManager.CercaConto();
                        break;
                    case 5:
                        BancaManager.EffettuaPrelievo();
                        break;
                    case 6:
                        BancaManager.EffettuaVersamento();
                        break;
                    case 7:
                        BancaManager.SalvaSuFile();
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
