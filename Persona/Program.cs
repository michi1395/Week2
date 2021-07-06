using System;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona(); //quando non ho istanziato il costruttore
            p.Nome = "..";
            p.Cognome = "..";
            p.CodiceFiscale = "..";


            Persona p = new Persona("Michela", "Putzu");    // quando istanzio un costruttore
            p.CodiceFiscale = "PTZMHL...";                  //posso usare il costruttore o richiamarle così
            string nome = p.Nome; //prende il nome

            string dati = p.OttieniDatiDati();
            Console.WriteLine(dati);

        }
    }
}
