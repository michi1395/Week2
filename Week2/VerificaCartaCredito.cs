using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    public static class VerificaCartaCredito
    {
        public static void Start()
        {
            int [] numeroCarta = InsertNumber();
            int sommaNumeri = CheckVal(numeroCarta);
            ValCard(sommaNumeri);
        }
        static int[] InsertNumber()
        {
            Console.WriteLine("Inserisci il numero della tua carta di credito:");
            int N = 16;
            int[] numeroCarta = new int[N];
            for (int i = 0; i < N; i++)
            {
                numeroCarta[i] = CheckNum(numeroCarta[i]);
            }
            return numeroCarta;
        }

        static int CheckNum(int num)
        {
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Puoi inserire solo numeri! Riprova:");
            }

            return num;

        }

        static int CheckVal(int[] myNumber)
        {
            int sum = 0;
            for (int i = 0; i < myNumber.Length; i++)
            {
                if (i % 2 == 0)
                {
                    myNumber[i] = 2 * myNumber[i];
                    if (myNumber[i] > 9)
                    {
                        myNumber[i] = myNumber[i] - 9;
                    }
                }

                sum = sum + myNumber[i];

            }
            return sum;
        }

        static void ValCard(int sum)
        {
            if (sum % 10 == 0)
            {
                Console.WriteLine("Il numero della carta è VALIDO!");
            }
            else
            {
                Console.WriteLine("Il numero della carta NON è VALIDO!");
            }
        }

    }
}
    


