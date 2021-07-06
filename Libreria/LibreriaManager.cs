using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class LibreriaManager
    {
        List<Libro> libri = new List<Libro>();        
        public void AggiungiLibro()
        {
            Libro libro = new Libro();
            Console.WriteLine("Inserisci il titolo del libro da aggiungere");
            libro.Titolo = Console.ReadLine();
            Console.WriteLine("Inserisci l'autore del libro da aggiungere");
            libro.Autore = Console.ReadLine();
            Console.WriteLine("Inserisci il genere del libro da aggiungere");
            libro.Genere = Console.ReadLine();
            Console.WriteLine("Inserisci il prezzo del libro da aggiungere");
            libro.Prezzo = CheckNum();

            libri.Add(libro);
        }

        public void EliminaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da eliminare");
            string titolo = Console.ReadLine();
            Libro libroDaEliminare = CercaLibro(titolo);
            libri.Remove(libroDaEliminare);
        }

        public Libro CercaLibro(string titolo)
        {
            foreach(Libro libro in libri)
            {
                if (libro.Titolo==titolo)
                {
                    return libro;
                }
                else
                {
                    return null;
                }
            }
        }


        public double CheckNum()
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
