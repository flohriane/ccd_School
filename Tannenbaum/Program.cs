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
            View Tannenbaum = new View();

            // Benutzereingabe Zeilenhöhe
            int height = Tannenbaum.GetNumberOfLines();
            // Benutzereingabe ob Stern auf Spitze oder nicht
            bool star = Tannenbaum.GetStar();

            if (star)
            {
                Tannenbaum.ZeichnenMitSpitze(height);
            }
            else
            {
                Tannenbaum.Zeichnen(height);
            }
 
            Tannenbaum.EndProgramm();
        }
    }
}
