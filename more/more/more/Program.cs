using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more
{
    class Program
    {
        static void Main(string[] args)
        {
            int zähler = 0;
            string zeile;

            StreamReader pfad = new StreamReader (@"C:\Users\FlohrCh\Documents\ccd School\Weinachtsgedicht.txt");

            while ((zeile = pfad.ReadLine()) != null)
            {
                Console.WriteLine(zeile);
                zähler++;
            }

            pfad.Close();

            Console.WriteLine("Die Datei enthält {0} Zeilen", zähler);
        }
    }
}
