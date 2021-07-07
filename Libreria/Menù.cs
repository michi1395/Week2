using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Menù
    {
        public static void Start()
        {
            Console.WriteLine("Benvenuto nella libreria");

            LibreriaManager.LeggiDaFile();

            bool continuare = true;
            do
            {
                Console.WriteLine("Premi 1 per inserire un nuovo libro");
                Console.WriteLine("Premi 2 per elimare un libro");
                Console.WriteLine("Premi 3 per modificare un libro");
                Console.WriteLine("Premi 4 per stampare lista libri");
                Console.WriteLine("Premi 5 per cercare un libro per genere");
                Console.WriteLine("Premi 0 se hai terminato!");

                int scelta = 0;
                bool isInt = true;

                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                } while (!isInt);

                switch (scelta)
                {
                    case 1:
                        LibreriaManager.AggiungiLibro();
                        break;
                    case 2:
                        LibreriaManager.EliminaLibro();
                        break;
                    case 3:
                        LibreriaManager.ModificaLibro();
                        break;
                    case 4:
                        LibreriaManager.StampaLibri();
                        break;
                    case 5:
                        LibreriaManager.CercaLibroPerGenere();
                        break;
                    case 0:
                        continuare = false;
                        LibreriaManager.SalvaSuFile();
                        break;
                    default:
                        Console.WriteLine("La scelta è sbagliata... Riprova");
                        break;

                }
            } while (continuare);
        }
    }
}
