using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    class Persona
    {
        //Proprietà
        //prop tab tab
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public string CodiceFiscale { get; set; }



        //Costruttori: se  voglio poter inizializzare la mia variabile con queste proprietà utilizzo il costruttore
        //ctor tab tab
        public Persona()
        {
        
        }
        
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        //Metodi: cose che fa esattamente la persona
        public string OttieniDati()
        {
            string dati = $"Ciao mi chiamo {Nome} {Cognome} e ho {Eta} anni";
        }

    }
}
