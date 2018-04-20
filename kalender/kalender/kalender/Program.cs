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
            var cli = new CLI(args);
            var ui = new UI();

            var monat_jahr = ui.Monat_Jahr_einlesen();

            var kalender_liste = Monatskalender.Kalender_erstellen(monat_jahr); // hier muss die Angabe aus der Kommandozeile rein

            ui.Kalender_ausgeben(kalender_liste);
        }
    }
}
