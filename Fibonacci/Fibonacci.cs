using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        public static void Start()
        {
            Console.WriteLine("Inserisci il numero di elementi per la serie di Fibonacci:");
            int numeroDaCalcolare = CheckNum();
            int[] serieFib = new int[numeroDaCalcolare];
            serieFib=FibonacciIterazione(numeroDaCalcolare);
            //serieFib=FibonacciRicorsione(numeroDaCalcolare);
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

        static int [] FibonacciIterazione(int numero)
        {
            int [] serie = new int [numero];
            serie[0] = 1;
            serie[1] = 1;
            for(int i=2;i<numero; i++)
            {
                serie[i] = serie[i-2]+serie[i-1];
                
                Console.WriteLine($"Il valore in posizione {i} è {serie[i]}");

            }
            return serie;
        }

        //static int[] FibonacciRicorsione(int numero)
        //{
        //    int[] serie = new int[numero];
        //    int totale = 0;
            
        //        if(numero<10)
        //        {
        //        totale = totale + FibonacciRicorsione(totale + 1);
        //            serie[numero] = FibonacciRicorsione(totale);

        //            Console.WriteLine($"Il valore in posizione {totale} è {serie[totale]}");
        //        }
            //return serie;
        }


    }

