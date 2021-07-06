using System;
using System.IO;    //si utilizza per i file

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"E:\Pink Academy\Prova.txt"; //aggiungo anche il nome del mio file

            #region

            StreamWriter sw = new StreamWriter(path); //creami un oggetto che va nel path
            //dobbiamo andare nella cartella dove salvare o leggere il file, bisogna passarlo
            //in ingresso

            //per scrivere:
            sw.WriteLine("Ciao a tutte!!!");

            //quando termino devo chiudere la connessione con il file

            sw.Close();
            
            #endregion

            //C'è un nuovo modo di scrivere dove la chiusura è automatica
            //importo la using all'interno:

            using(StreamWriter sw1=new StreamWriter(path)) //quando lo eseguo così apre la connessione e la chiude alla fine delle parentesi }
            {
                sw1.WriteLine("Buongiorno!!"); //scritto così cancella quello che c'era prima
            }

            using (StreamWriter sw1 = new StreamWriter(path,true)) //appende al file ciò che scriviamo
            {
                sw1.WriteLine("Come state?");
            }

            //vogliamo poter leggere su file

            using (StreamReader sw1=new StreamReader(path))
            {
                string contenutoFile = sw1.ReadToEnd(); //se vogliamo leggere tutto il file
                var arrayDiRighe = contenutoFile.Split("\r\n"); //Crea nuova riga e vai a capo: conta il numero di righe e alla fine inserisce una riga vuota
            }


            using (StreamReader sw1 = new StreamReader(path))
            {
                string contenutFile = sw1.ReadLine(); //se vogliamo leggere fino alla fine della linea
            }
            

        }
    }
}
