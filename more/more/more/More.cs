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
            var text = Text_finden();
            Text_verarbeiten(text);
        }

        private static StreamReader Text_finden()
        {
            StreamReader textStream = new StreamReader(@"C:\Users\FlohrCh\Documents\ccd School\Weinachtsgedicht.txt");
            return textStream;
        }

        private void Text_verarbeiten(StreamReader text)
        {
            var abbruch = false;

            while (abbruch == false)
            {
                Zwanzig_Zeilen_Text_verarbeiten(text);
                abbruch = Abbruch_prüfen();
                if (abbruch) text.Close();
            }
        }

        private void Zwanzig_Zeilen_Text_verarbeiten(StreamReader text)
        {
            for (int i = 1; i <= 20; i++)
            {
                Text_zeilenweise_lesen(text);
            }
        }

    private bool Abbruch_prüfen()
        {
            var cki = Abbruch_ermöglichen();
            return Abbruch_erwünscht(cki);            
        }

        private static ConsoleKeyInfo Abbruch_ermöglichen()
        {
            Console.WriteLine("\n\tweiterlesen mit beliebiger Taste - Programm verlassen mit der ESC-Taste");
            return Console.ReadKey();
        }

        private bool Abbruch_erwünscht(ConsoleKeyInfo cki)
        {
            if (cki.Key == ConsoleKey.Escape) 
            {
                return true;
            }
            else
            {
                Console.WriteLine("\n");
                return false;
            }
        }

        private static void Text_zeilenweise_lesen(StreamReader text)
        {
            Console.WriteLine(text.ReadLine());
        }
    }
}
