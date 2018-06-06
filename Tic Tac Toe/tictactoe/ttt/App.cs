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
        }
    }
}
