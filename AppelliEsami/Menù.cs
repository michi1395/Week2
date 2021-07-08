using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppelliEsami
{
    class Menù
    {
        static public void Start()
        {
            Console.WriteLine("SEZIONE APPELLI DISPONIBILI");
            int scelta = 0;
            do
            {
                Console.WriteLine("\nPremi 1 per Vedere tutti gli esami");
                Console.WriteLine("Premi 2 per Aggiungere un nuovo appello");
                Console.WriteLine("Premi 3 per Eliminare appello");
                Console.WriteLine("Premi 4 per Cercare appelli per tipo");
                Console.WriteLine("Premi 0 per Uscire");



                bool isInt = true;

                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                    if (!isInt)
                    {
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                    }
                } while (!isInt);
                switch (scelta)
                {
                    case 1:
                        AppelliManager.VisualizzaAppelli();
                        break;
                    case 2:
                        AppelliManager.AggiungiAppello();
                        break;
                    case 3:
                        AppelliManager.EliminaAppello();
                        break;
                    case 4:
                        AppelliManager.CercaAppelloPerTipo();
                        break;
                    case 0:
                        AppelliManager.SalvaSuFile();
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                        break;

                }
            } while (scelta != 0);
        }
    }
}
