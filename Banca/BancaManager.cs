using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banca.Conto;

namespace Banca
{
    class BancaManager
    {
        static List<Conto> conti = new List<Conto>();
        static string path = @"E:\Pink Academy\Banca.txt";
        public static void CreaNuovoConto()
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("Inserisci il nome e cognome dell'intestatario");
            string intestatario = Console.ReadLine();

            //conto.NumeroConto = TrovaNumero();
            //Console.WriteLine($"\nIl numero conto è {conto.NumeroConto}");

            Console.WriteLine("\nInserisci la tipologia del conto");
            Tipologia TipoDiConto = InserisciTipoDiConto();

            Conto conto = new Conto(intestatario, TipoDiConto);


            conti.Add(conto);
        }

        public static Tipologia InserisciTipoDiConto()
        {
            Console.WriteLine($"Premi {(int)Tipologia.Corrente} per creare un conto {Tipologia.Corrente}");
            Console.WriteLine($"Premi {(int)Tipologia.Risparmio} per creare un conto {Tipologia.Risparmio}");
            int tipo = Check();
            return (Tipologia)tipo;
        }

        public static void EliminaConto()
        {
            Console.WriteLine("Inserisci il numero del conto da eliminare");
            StampaConti();
            int numConto = 0;
            bool isInt = false;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numConto);
            } while (!isInt || numConto < 0 || numConto > conti.Count);

            Conto contoDaEliminare = conti.ElementAt(numConto - 1);
            conti.Remove(contoDaEliminare);

        }

        public static void StampaConti(List<Conto> conti)
        {
            if (conti.Count>0)
            {
                int count = 1;
                Console.WriteLine("\tIntestatario\t\t Tipologia conto\t\t Saldo");
                foreach (Conto conto in conti)
                {
                    Console.WriteLine($"{count} -> {conto.Intestatario}\t\t {conto.TipoDiConto}\t\t\t {conto.Saldo}");
                    count++;
                }

            }
            else
            {
                Console.WriteLine("Nessun conto presente!");
            }

        }
        public static void StampaConti()
        {
            StampaConti(conti);
        }

        public static void SalvaSuFile()
        {

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("\tIntestatario\t\t Tipologia conto\t\t Saldo");
            }
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                if (conti.Count > 0)
                {
                    int count = 1;
                    foreach (Conto conto in conti)
                    {
                        sw.WriteLine($"{count} -> {conto.Intestatario}\t\t {conto.TipoDiConto}\t\t\t {conto.Saldo}");
                        count++;
                    }
                }
            }
        }
        public static void CercaConto()
        {
            
            Console.WriteLine("Inserisci il tipo di conto da cercare");
            Tipologia TipologiaConto = InserisciTipoDiConto();

            List<Conto> contiPerTipo = new List<Conto>();
            foreach (Conto conto in conti)
            {
                if (conto.TipoDiConto == TipologiaConto)
                {
                    contiPerTipo.Add(conto);
                }
            }
            if (contiPerTipo.Count > 0)
            {
                StampaConti(contiPerTipo);
            }
            else
            {
                Console.WriteLine($"Non sono presenti conti {TipologiaConto}");
            }
        }

        public static void EffettuaVersamento()
        {
            Console.WriteLine("Inserisci il numero del conto in cui vuoi versare");
            StampaConti();
            int numConto = 0;
            bool isInt = false;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numConto);
            } while (!isInt || numConto < 0 || numConto > conti.Count);

            Conto contoDaModificare = conti.ElementAt(numConto - 1);
            Console.WriteLine("Quanto vuoi versare?");
            double versamento = CheckNum();
            contoDaModificare.AggiornaSaldo(versamento);
    
        }

        public static void EffettuaPrelievo()
        {
            Console.WriteLine("Inserisci il numero del conto in cui vuoi prelevare");
            StampaConti();
            int numConto = 0;
            bool isInt = false;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out numConto);
            } while (!isInt || numConto < 0 || numConto > conti.Count);

            Conto contoDaModificare = conti.ElementAt(numConto - 1);


            if (contoDaModificare.TipoDiConto == 0)
            {
                Console.WriteLine("Quanto vuoi prelevare?");
                double prelievo = CheckNum();
                contoDaModificare.AggiornaSaldo(-prelievo);
            }
            else
            {
                Console.WriteLine("Non puoi effettuare prelievi per il CONTO RISPARMIO!");
            }

        }


        //public static int TrovaNumero()
        //{
        //    Random random = new Random();
        //    int numero = 0; 

        //    for (int i = 0; i < conti.Count; i++)
        //        {
        //            Conto conto = conti[i];
        //        do
        //        {
        //            numero = random.Next(1, 1000);
        //        }
        //        while (conto.NumeroConto == numero);      
        //    }
        //    if (numero==0)
        //    {
        //        numero= random.Next(1, 1000);
        //    }
        //    return numero;
        //}

        public static double CheckNum()
        {
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Puoi inserire solo numeri! Riprova:");
            }

            return num;

        }

        public static int Check()
        {
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num)|| num<0||num>1)
            {
                Console.WriteLine("Puoi inserire solo 0 o 1! Riprova:");
            }

            return num;

        }
    }
}

