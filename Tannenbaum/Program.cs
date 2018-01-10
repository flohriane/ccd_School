using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ausgabe eines Tannenbaums auf der Konsole mit oder ohne Stern in vom Benutzer festgelegter Höhe

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            var edeltanne = Tannenbaum.Zeichnen(5);
            View.Zeige_Tannenbaum(edeltanne);
        }
    }

    class View {
        public static void Zeige_Tannenbaum(string tanne) {
            Console.WriteLine(tanne);
        }
    }
    
    class Tannenbaum
    {
        public static string Zeichnen(int height)
        {
            var baum = "";
            for (var i = 1; i <= height; i++)
                baum += Astebene(height, i);
            baum += Indent(height - 1, "I");
            return baum;
        }


        static string Astebene(int height, int ebene) {
            var ast = Repeat(2 * ebene - 1, 'x');
            return Indent(height - ebene, ast);
        }
        
        static string Indent(int n, string chars) {
            return "".PadLeft(n) + chars + "\n";
        }

        static string Repeat(int n, char c)
        {
            return "".PadLeft(n, c);   
        }
    }
}
