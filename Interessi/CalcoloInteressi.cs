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
            double importoDaVincolare = ChiediImporto();
            int anni = ChiediAnni();
            double importoFinaleIter=CalcoloValoreIterativo(importoDaVincolare,anni);
            double importoFinale = CalcoloValoreRicorsivo(importoDaVincolare, anni);
            Console.WriteLine($"Dopo {anni} da {importoDaVincolare} avrai {importoFinale}");

        }

        static double CalcoloValoreRicorsivo(double importo,int anni)
        {
            if (anni > 0)
            {
                return CalcoloValoreRicorsivo(importo + (importo * 3 / 100), anni - 1);
            }
            else
            {
                return importo;
            }

        }
        static double CalcoloValoreIterativo(double importoDaVincolare,int anni)
        {
            double importoConInteressi = importoDaVincolare;
            for (int i=0;i<anni; i++)
            {
                double importoAnnoPrecedente = importoConInteressi;
                double interessi = importoConInteressi * anni / 100;
                importoConInteressi = importoConInteressi + interessi;
                Console.WriteLine($"Dopo {i+1} anni, da {importoAnnoPrecedente} avrai  maturato {interessi} e il tuo nuovo capitale sarà {importoConInteressi}");
            }
            return importoConInteressi;
        }

        static double ChiediImporto()
        {
            Console.WriteLine("Inserisci importo di denaro iniziale:");
            double importoDaVincolare = CheckNum();
            return importoDaVincolare;
        }

        static int ChiediAnni()
        {
            Console.WriteLine("Per quanti anni vuoi vincolare?");
            int anni = CheckNumInt();
            return anni;

        }
        static double CheckNum()
        {
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Puoi inserire solo numeri! Riprova:");
            }

            return num;

        }
        static int CheckNumInt()
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
