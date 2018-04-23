using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    class Program
    {
        static void Main(string[] args)
        {
            var kalender_liste = Monatskalender.Kalender_erstellen(args); // hier muss die Angabe aus der Kommandozeile rein

            var ui = new UI();
            ui.Kalender_ausgeben(kalender_liste);
        }
    }
}
