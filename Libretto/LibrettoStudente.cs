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
            string [] nome =NomeStudente();
            string[] cognome = CognomeStudente();
            int media = mediaEsami();
        }
        static int [] NomeStudente()
        {
            string nomeStudente = null;
            Console.WriteLine("Inserisci nome dello studente:");
            nomeStudente = CheckIns();
            return nomeStudente;
        }

        static string [] CognomeStudente()
        {
            string cognomeStudente = null;
            Console.WriteLine("Inserisci cognome dello studente:");
            cognomeStudente = CheckIns();
            return cognomeStudente;
        }

        static int mediaEsami()
        {
            Console.WriteLine("Quanti esami hai sostenuto?");
            int numeroEsami = CheckNum();
            for (int i=0;i<numeroEsami;i++)
            {

            }

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
