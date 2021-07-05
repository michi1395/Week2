using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto
{
    class LibrettoStudente
    {
        public static void Start()
        {
            string nome =NomeStudente();
            string cognome = CognomeStudente();
            decimal media = mediaEsami();

            Console.WriteLine($"\nDATI STUDENTE\nNome: {nome}\nCognome: {cognome}\nMedia dei voti: {media}");
        }
        static string NomeStudente()
        {
            string nomeStudente = null;
            Console.WriteLine("Inserisci nome dello studente:");
            nomeStudente = CheckIns();
            return nomeStudente;
        }

        static string CognomeStudente()
        {
            string cognomeStudente = null;
            Console.WriteLine("Inserisci cognome dello studente:");
            cognomeStudente = CheckIns();
            return cognomeStudente;
        }

        static decimal mediaEsami()
        {
            Console.WriteLine("Quanti esami hai sostenuto?");
            int numeroEsami = CheckNum();
            //decimal media = 0;
            decimal sum = 0;
            int[] esami = new int[numeroEsami];
            for (int i=0;i<numeroEsami;i++)
            {
                Console.WriteLine("Inserisci esame:");
                esami[i] = CheckNum();
                sum = sum + esami[i];
                
            }
            decimal media = sum / esami.Length;

            return media;

        }

    
        static string CheckIns()
        {
            string s = Console.ReadLine();


            if (int.TryParse(s, out int a) == true)
            {
                Console.WriteLine("Puoi inserire solo stringhe! Riprova:");
                s = null;
            }

            return s;
        }
        static int CheckNum()
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
