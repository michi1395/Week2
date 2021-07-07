using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Banca.ContoCorrente;

namespace Banca
{
    class AzioniUtente
    {
        static List<ContoCorrente> conti = new List<ContoCorrente>();
        public static void CreaNuovoConto()
        {
            ContoCorrente conto = new ContoCorrente();
            Console.WriteLine("Inserisci il nome dell'intestatario");
            conto.Intestatatrio = Console.ReadLine();

            Console.WriteLine("Inserisci il numero conto");
            conto.Saldo = CheckNum();

            Console.WriteLine("Inserisci la tipologia del conto");
            conto.TipoDiConto = InserisciTipoDiConto();

            Console.WriteLine("Inserisci il saldo");
            conto.Saldo = CheckNum();

            conti.Add(conto);
        }

        public static Tipologia InserisciTipoDiConto()
        {
            Console.WriteLine($"Premi {(int)Tipologia.Corrente} per il genere {Tipologia.Corrente}");
            Console.WriteLine($"Premi {(int)Tipologia.Risparmio} per il genere {Tipologia.Risparmio}");
            int tipo = Check();
            return (Tipologia)tipo;
        }

        public static void EliminaConto()
        {
            Console.WriteLine("Inserisci il nome del proprietario del conto da eliminare");
            string nome = Console.ReadLine();
            ContoCorrente contoDaEliminare = CercaIntestatario(nome);
            
            if (contoDaEliminare != null)
            {
                conti.Remove(contoDaEliminare);
            }

        }

        public static void StampaConti(List<ContoCorrente> conti)
        {
            Console.WriteLine("Intestatario\t\t Tipologia conto\t\t Saldo");
            foreach (ContoCorrente conto in conti)
            {
                Console.WriteLine($"{conto.Intestatatrio}\t\t {conto.TipoDiConto}\t {conto.Saldo}");
            }

        }
        public static void StampaConti()
        {
            StampaConti(conti);
        }

        public static ContoCorrente CercaIntestatario(string nomeIntestatario)
        {
            foreach (ContoCorrente conto in conti)
            {
                if (conto.Intestatatrio == nomeIntestatario)
                {
                    return conto;
                }

            }
            return null;
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
