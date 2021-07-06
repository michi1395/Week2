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
            int save = ChiediDoveVuoiStampare();

            double importoFinaleIter = CalcoloValoreIterativo(importoDaVincolare, anni,save);
            double importoFinale = CalcoloValoreRicorsivo(importoDaVincolare, anni);
            Console.WriteLine($"Dopo {anni} anni da {importoDaVincolare} avrai {importoFinale}");

        }

        static double CalcoloValoreRicorsivo(double importo, int anni)
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
        static double CalcoloValoreIterativo(double importoDaVincolare, int anni,int save)
        {
            double importoConInteressi = importoDaVincolare;
            for (int i = 0; i < anni; i++)
            {
                double importoAnnoPrecedente = importoConInteressi;
                double interessi = importoConInteressi * anni / 100;
                importoConInteressi = importoConInteressi + interessi;
                string messaggio = ($"Dopo il {i + 1}° anno, da  {importoAnnoPrecedente}  avrai maturato  { interessi}  e il tuo nuovo capitale sarà  { importoConInteressi} ");


                FileManager.Indirizzatore(messaggio, i,save); //richiamo un'altra classe
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

        static int ChiediDoveVuoiStampare()
        {
            int tipoDiOutput = 0;
            Console.WriteLine("Prendi 0 per stampare su file, premi 1 per stampare a video");
            while(!int.TryParse(Console.ReadLine(), out tipoDiOutput))
            {
                Console.WriteLine("Puoi inserire solo 0 o 1! Riprova:");
            }

            return tipoDiOutput;
        }
        }
    }

