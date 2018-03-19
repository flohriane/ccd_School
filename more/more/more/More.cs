using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace more
{
    public class More
    {
        private static void More_starten()
        {

            StreamReader text = new StreamReader(@"C:\Users\FlohrCh\Documents\ccd School\Weinachtsgedicht.txt");

            var zähler = Text_zeilenweise_lesen(text);
        }


    //Console.WriteLine("Die Datei enthält {0} Zeilen", zähler);           
    private static int Text_zeilenweise_lesen(StreamReader text)
    {
        int zähler = 0;
        string zeile;


        while ((zeile = text.ReadLine()) != null)
        {
            Console.WriteLine(zeile);
            zähler++;
        }

        text.Close();

        return zähler;

    }
}
}
