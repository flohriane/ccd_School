using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace more
{
    public class More_Lambda
    {
        public void Textausgabe_formatieren()
        {
            string pfad = @"C:\Users\FlohrCh\Documents\ccd School\Weinachtsgedicht.txt";

            string text = File.ReadAllText(pfad);
            int textlänge = text.Length;
            int indexZeilenumbruch = text.IndexOf("\n");
            int zähler = 1;

            do
            {
                if (zähler == 20)
                {
                    Console.WriteLine("\n--- Weiter mit jeder Taste - Abbruch mit [ESC] ---\n");

                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("\f");                              // Seitenvorschub funktioniert nicht auf der Konsole ???
                        zähler = 1;
                    }
                }

                Console.WriteLine(text.Substring(0, indexZeilenumbruch)); // Ausgabe einer Zeile
                text = text.Substring(indexZeilenumbruch + 1);            // gerade ausgegebene Zeile löschen
                textlänge = text.Length;                                  // Textlänge aktualisieren
                indexZeilenumbruch = text.IndexOf("\n");                  // nächster Zeilenumbruch in gekürztem Text
                zähler++;

            } while (textlänge > 0);
        }
    }
}

