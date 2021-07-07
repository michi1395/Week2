using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Libreria.Libro;

namespace Libreria
{
    class LibreriaManager
    {
        static List<Libro> libri = new List<Libro>();
        static string path = @"E:\Pink Academy\Libri.txt";
        public static void AggiungiLibro()
        {
            Libro libro = new Libro();
            Console.WriteLine("Inserisci il titolo del libro da aggiungere");
            libro.Titolo = Console.ReadLine();
            
            Console.WriteLine("Inserisci l'autore del libro da aggiungere");
            libro.Autore = Console.ReadLine();

            Console.WriteLine("Inserisci il genere del libro da aggiungere");
            libro.Genere = InserisciGenere();

            Console.WriteLine("Inserisci il prezzo del libro da aggiungere");
            libro.Prezzo = CheckNum();

            libri.Add(libro);
        }

        public static void EliminaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da eliminare");
            string titolo = Console.ReadLine();
            Libro libroDaEliminare = CercaLibro(titolo);
            if(libroDaEliminare!=null)
            { 
                libri.Remove(libroDaEliminare); 
            }
           
        }

        public static void ModificaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da modificare");
            string titolo = Console.ReadLine();
            Libro libroDaModificare = CercaLibro(titolo);
            libri.Remove(libroDaModificare);
            bool continuare = true;
            do
            {
                Console.WriteLine("Premi 1 per modificare il titolo");
                Console.WriteLine("Premi 2 per modificare l'autore");
                Console.WriteLine("Premi 3 per modificare il genere");
                Console.WriteLine("Premi 4 per modificare il prezzo");
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
                        Console.WriteLine("Inserisci il titolo modificato");
                        libroDaModificare.Titolo = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Inserisci l'autore modificato");
                        libroDaModificare.Autore = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Inserisci il genere modificato");
                        libroDaModificare.Genere = InserisciGenere();
                        break;
                    case 4:
                        Console.WriteLine("Inserisci il prezzo modificato");
                        libroDaModificare.Prezzo= CheckNum();
                        break;
                    case 0:
                        continuare = false;
                        break;

                }
            } while (continuare);

            libri.Add(libroDaModificare);

        }

        public static void StampaLibri(List<Libro> libri)
        {
            Console.WriteLine("Titolo\t\t Autore\t\t Genere\t\t Prezzo\t");
            foreach (Libro libro in libri)
            {
                Console.WriteLine($"{libro.Titolo}\t\t {libro.Autore}\t {libro.Genere}\t {libro.Prezzo}\t\t");
            }

        }
        public static void SalvaSuFile()
        {
            
            using(StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Titolo\t\t Autore\t\t Genere\t\t Prezzo");
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Libro libro in libri)
                {
                    sw.WriteLine($"{libro.Titolo}\t\t {libro.Autore}\t\t {libro.Genere}\t\t {libro.Prezzo}");
                }
            }
        }

        public static void LeggiDaFile()
        {
            //File è una classe che fa parte della system.IO --> metodo Exists a cui passiamo il path
            if (File.Exists(path))
            {
                Libro libro = new Libro();
                using (StreamReader sr = new StreamReader(path))
                {
                    string file = sr.ReadToEnd();

                    //bool stringaVuota = String.IsNullOrEmpty(file); 
                    //equivale a scrivere file==""

                    if (String.IsNullOrEmpty(file))
                    {
                        Console.WriteLine("Non ci sono libri!!");
                    }
                    else
                    {
                        string[] righeDelMioFile = file.Split("\r\n");
                        //riga 1 -> intestazione
                        //riga 2 -> titolo\t\t autore\t genere\t prezzo
                        //riga 3 -> titolo\t\t autore\t genere\t prezzo
                        //riga 4 ....
                        //...
                        //riga vuota

                        for (int i = 1; i < righeDelMioFile.Length - 1; i++)
                        {
                            string riga = righeDelMioFile[i];
                            string[] campiDellaRiga = riga.Split("\t\t");

                            libro.Autore = campiDellaRiga[0];
                            libro.Titolo = campiDellaRiga[1];
                            libro.Genere = (Tipologia)Enum.Parse(typeof(Tipologia), campiDellaRiga[2]); //typeof restituisce il tipo che gli passo
                            libro.Prezzo = Convert.ToDouble(campiDellaRiga[3]);

                            libri.Add(libro);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Non ci sono libri!!");
            }
        }

        public static void StampaLibri()
        {
            StampaLibri(libri);
        }
        public static void CercaLibroPerGenere()
        {
            Console.WriteLine("Inserisci il genere da cercare");
            Tipologia TipologiaGenere = InserisciGenere();

            List<Libro> libriPerGenere = new List<Libro>();
            foreach(Libro libro in libri)
            {
                if(libro.Genere==TipologiaGenere)
                {
                    libriPerGenere.Add(libro);
                }
            }
            if(libriPerGenere.Count>0)
            {
                StampaLibri(libriPerGenere);
            }
            else
            {
                Console.WriteLine($"Non sono presenti libri {TipologiaGenere}");
            }
        }

        public static Libro CercaLibro(string titolo)
        {
            
            foreach(Libro libro in libri)
            {
                if (libro.Titolo==titolo)
                {
                    return libro;
                }

            }
            return null;
        }

        public static Tipologia InserisciGenere ()
        {
            
            Console.WriteLine($"Premi {(int)Tipologia.Narrativa} per il genere {Tipologia.Narrativa}");
            Console.WriteLine($"Premi {(int)Tipologia.Storico} per il genere {Tipologia.Storico}");
            Console.WriteLine($"Premi {(int)Tipologia.Fantasy} per il genere {Tipologia.Fantasy}");
            double genere = CheckNum();
            return (Tipologia)genere;
        }

        public static double CheckNum()
        {
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Puoi inserire solo numeri! Riprova:");
            }

            return num;

        }
    }
}
