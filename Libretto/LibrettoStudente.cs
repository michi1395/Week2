
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto
{
    class LibrettoStudente
    {
        public static string path = @"E:\Pink Academy\LibrettoStudente.txt";
        public static void Start()
        {
            string nome = NomeStudente();
            string cognome = CognomeStudente();
            double media = mediaEsami();

            string messaggio=("Nome\t Cognome\t Media");
            string dati=($"{nome}\t {cognome}\t\t {media}");
            
            using (StreamWriter sw1 = new StreamWriter(path, false))
            {
                sw1.WriteLine(messaggio);
                sw1.WriteLine(dati);
            }
            

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

        static double mediaEsami()
        {
            Console.WriteLine("Quanti esami hai sostenuto?");
            int numeroEsami = CheckNum();
            int[] votiEsami = new int[numeroEsami];
            double mean = 0;
            for (int i = 0; i < numeroEsami; i++)
            {
                Console.WriteLine("Inserisci voto:");
                votiEsami[i] = CheckNum();
            }
            double somma = 0;
            for (int i = 0; i < numeroEsami; i++)
            {
                somma = somma + votiEsami[i];
            }
            mean = somma / numeroEsami;
            return mean;

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
