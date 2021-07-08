using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppelliEsami.Appello;

namespace AppelliEsami
{
    class AppelliManager
    {
        static List<Appello> appelli = new List<Appello>();
        static string path = @"E:\Pink Academy\AppelliEsami.txt";
        public static void VisualizzaAppelli()
        {
            VisualizzaAppelli(appelli);
        }
        public static void VisualizzaAppelli(List<Appello> appelli)
        {
            if (appelli.Count > 0)
            {
                
                Console.WriteLine("Nome materia\t\t Data verbalizzazione\t\t Tipologia");
                foreach (Appello appello in appelli)
                {
                    Console.WriteLine($"{appello.NomeMateria}\t\t\t {appello.DataVerbalizzazione.Day}/{appello.DataVerbalizzazione.Month}/{appello.DataVerbalizzazione.Year}\t\t\t {appello.Modalità}");
                }

            }
            else
            {
                Console.WriteLine("Nessun appello presente!");
            }
        }
        public static void AggiungiAppello()
        {
            Appello appello = new Appello();
            Console.WriteLine("\n");
            Console.WriteLine("Inserisci il nome della materia");
            appello.NomeMateria= Console.ReadLine();

            
            bool isDate = true;
            DateTime dataInserita;
            DateTime now = DateTime.Now;
            now = now.Date;
            now = now.AddDays(10);
            do
            {
                Console.WriteLine("\nInserisci la data della verbalizzazione");
                isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);
                

            } while (!isDate || dataInserita < now);
           
            appello.DataVerbalizzazione = dataInserita;

            Console.WriteLine("\nInserisci la tipologia del conto");
            appello.Modalità = InserisciTipoEsame();
            
            appelli.Add(appello);
        }
        public static Tipologia InserisciTipoEsame()
        {
        
                Console.WriteLine($"Premi {(int)Tipologia.Scritto} per creare un conto {Tipologia.Scritto}");
                Console.WriteLine($"Premi {(int)Tipologia.Orale} per creare un conto {Tipologia.Orale}");
                int tipo = Check();
                return (Tipologia)tipo;
    
        }
        public static void EliminaAppello()
        {
            Console.WriteLine("Inserisci il nome della materia");
            string materia = Console.ReadLine();
            Appello appelloDaEliminare = CercaAppello(materia);
            if (appelloDaEliminare != null)
            {
                appelli.Remove(appelloDaEliminare);
            }

        }
        public static Appello CercaAppello(string materia)
        {

            foreach (Appello appello in appelli)
            {
                if (appello.NomeMateria == materia)
                {
                    return appello;
                }

            }
            return null;
        }

        public static void CercaAppelloPerTipo()
        {
            Console.WriteLine("Inserisci il tipo esame da cercare");
            Tipologia TipologiaEsame = InserisciTipoEsame();

            List<Appello> esamiPerTipo = new List<Appello>();
            foreach (Appello appello in appelli)
            {
                if (appello.Modalità == TipologiaEsame)
                {
                    esamiPerTipo.Add(appello);
                }
            }
            if (esamiPerTipo.Count > 0)
            {
                VisualizzaAppelli(esamiPerTipo);
            }
            else
            {
                Console.WriteLine($"Non sono presenti libri {TipologiaEsame}");
            }

        }
        public static void SalvaSuFile()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Nome materia\t\t Data verbalizzazione\t\t Tipologia");
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Appello appello in appelli)
                {
                    sw.WriteLine($"{appello.NomeMateria}\t\t\t {appello.DataVerbalizzazione.Day}/{appello.DataVerbalizzazione.Month}/{appello.DataVerbalizzazione.Year}\t\t\t {appello.Modalità}");
                }
            }
        }

        public static int Check()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num) || num < 0 || num > 1)
            {
                Console.WriteLine("Puoi inserire solo 0 o 1! Riprova:");
            }

            return num;

        }
    }
}

