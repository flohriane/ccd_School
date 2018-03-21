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
            var abbruch = false; 

            while (abbruch == false)
            {
                abbruch = Abbruch_prüfen();
                Zwanzig_Zeilen_Text_verarbeiten(text);
                if (abbruch) text.Close();
            }
        }

        private static StreamReader Text_finden()
        {
            StreamReader textStream = new StreamReader(@"C:\Users\FlohrCh\Documents\ccd School\Weinachtsgedicht.txt");
            return textStream;
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
            Console.WriteLine("\n\tmit ESC kann das Programm verlassen werden");
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
                return false;
            }
        }

        private static void Text_zeilenweise_lesen(StreamReader text)
        {
            Console.WriteLine(text.ReadLine());
        }
    }
}
