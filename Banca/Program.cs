using System;

namespace Banca
{
    class Program
    {
        //Scrivere un programma che permetta di gestire i conti correnti
        // I conti correnti hanno
        //Intestatatrio
        //TipoDiConto -> Corrente - Risparmio

        //Un utente può visualizzare tutti i conti
        //Un utente può creare un conto
        //Un utente può eliminare un conto
        //Filtrare un tipo di conto
        //Un utente può effettuare un prelievo 
        //Un utente può effettuare un versamento

        //Per aprire un nuovo conto, l'importo minimo deve essere di 100 euro

        static void Main(string[] args)
        {
            Menù.Start();
        }
    }
}
