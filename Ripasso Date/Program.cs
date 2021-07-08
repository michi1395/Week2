using System;

namespace Ripasso_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime();

            DateTime dt2 = new DateTime(2021, 07, 05); //Mi passa il giorno

            DateTime dt3 = DateTime.Now;
            DateTime dt4 = dt3.Date; //cancella ore minuti e secondi

            int anno = dt3.Year;
            int mese = dt3.Month;
            int giorno = dt3.Day;
            
            //aggiunta giorni
            var dt5 = dt3.AddDays(30); //aggiungimi giorni a quella data, variabile di tipo DateTime

            if(dt2.Date>dt4)
            {

            }

            //posso convertire una data in stringa

            DateTime dt8 = DateTime.Parse("06/07/2021");
            DateTime dt6 = DateTime.Parse("06-07-2021");
            DateTime dt7 = DateTime.Parse("06 07 2021");

            //gestire data come input utente
            Console.WriteLine("Inserisci una data");
            bool isDate = true;

            //Inserire una data antecedente alla date inserite
            DateTime dataInserita;
            do
            {
                isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);
                
            } while (!isDate || dataInserita>DateTime.Now.Date);

        }
    }
}
