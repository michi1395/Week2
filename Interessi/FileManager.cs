using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interessi
{
    class FileManager
    {
        public static string path = @"E:\Pink Academy\InteressiMaturati.txt";
        public static void Indirizzatore(string messaggio,int count, int formatoInt)
        {
            if(formatoInt==(int)Formato.File)
            {
                ScritturaFile(messaggio, count);
            }
            else 
            {
                Console.WriteLine(messaggio);
            }
        }
        public static void ScritturaFile(string messaggio, int count)
        {

            if (count == 0)
            {
                using (StreamWriter sw1 = new StreamWriter(path, false))
                {
                    sw1.WriteLine(messaggio);
                }
            }
            else
            {
                using (StreamWriter sw1 = new StreamWriter(path, true))
                {
                    sw1.WriteLine(messaggio);
                }
            }

        }
        enum Formato
        {
           File,    //0
           Console  //1
        }
    }
}

