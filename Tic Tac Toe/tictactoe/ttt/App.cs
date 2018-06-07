using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttt.contracts.daten;

namespace ttt
{
    class App
    {
        public static void Run(Spiel spiel, UI ui) 
        {
            spiel.Starten();
            ui.Spielstand_anzeigen();
            Gameloop(spiel, ui);
        }

        private static void Gameloop(Spiel spiel, UI ui)
        {
            // ToDo Schleife für laufendes Spiel, Abbruch bei "ende" und Zurücksetzen bei "neu"
            var kommando = ui.Kommando_lesen();
            var spielstand = Kommando_ausführen(kommando);
            ui.Spielstand_anzeigen();
        }

        private static string [,] Kommando_ausführen(string kommando)
        {
            var spielstand = new string[1 , 1]; // ToDo dummy ersetzen: mit aktuellen Spielstand aus Klasse "Spiel" holen
            return spielstand;
        }
    }
}
