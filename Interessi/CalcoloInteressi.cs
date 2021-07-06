using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine($"Dopo {anni} anni da {importoDaVincolare} avrai {importoFinale}");

        }

        static double CalcoloValoreRicorsivo(double importo,int anni)
        {
            if (anni > 0)
            {
                return CalcoloValoreRicorsivo(importo + (importo * anni / 100), anni - 1);
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
                ScritturaFile(i + 1, importoAnnoPrecedente, importoConInteressi, interessi);
            }
            return importoConInteressi;
        }

        static void ScritturaFile(int anno, double importoAnnoPrecedente, double importoConInteressi, double interessi)
        {
            var path = @"E:\Pink Academy\InteressiMaturati.txt";
            using (StreamWriter sw1 = new StreamWriter(path,true)) 
            {
                sw1.WriteLine($"Dopo il {anno}° anno, da  {importoAnnoPrecedente}  avrai maturato  { interessi}  e il tuo nuovo capitale sarà  { importoConInteressi} "); 
            }

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
