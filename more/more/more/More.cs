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
        public void Textausgabe_formatieren()
        {
            var textStream = Text_finden();
            Text_verarbeiten(textStream);
        }

        private static StreamReader Text_finden()
        {
            StreamReader textStream = new StreamReader(@"C:\Users\FlohrCh\Documents\ccd School\Weinachtsgedicht.txt");
            return textStream;
        }

        private static void Text_verarbeiten(StreamReader textStream)
        {
            var abbruch = false;

            while (abbruch == false)
            {
                Zwanzig_Zeilen_Text_verarbeiten(textStream);
                abbruch = Abbruch_prüfen();
                if (abbruch) textStream.Close();
            }
        }

        private static void Zwanzig_Zeilen_Text_verarbeiten(StreamReader text)
        {
            for (int i = 1; i < 20; i++)
            {
                Text_zeilenweise_lesen(text);
            }
        }

    private static bool Abbruch_prüfen()
        {
            var cki = Abbruch_ermöglichen();
            return Abbruch_erwünscht(cki);            
        }

        private static ConsoleKeyInfo Abbruch_ermöglichen()
        {
            Console.WriteLine("\n--- weiter mit jeder Taste - Abbruch mit [ESC] ---\n");
            return Console.ReadKey(true); 
        }

        private static bool Abbruch_erwünscht(ConsoleKeyInfo cki)
        {
            if (cki.Key == ConsoleKey.Escape) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Text_zeilenweise_lesen(StreamReader textStream)
        {
            Console.WriteLine(textStream.ReadLine());
        }
    }
}
