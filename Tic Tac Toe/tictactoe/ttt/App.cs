using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ttt.contracts.daten;
using ttt.schiedsrichter;

namespace ttt
{
    class App
    {
        private readonly TicTacToe _ttt;
        private readonly UI _ui;

        public App(TicTacToe ttt, UI ui) {
            _ttt = ttt;
            _ui = ui;
        }
        
        
        public static void Run() {
            var spielstand = _ttt.Starten();
            _ui.Spielstand_anzeigen(spielstand);
            Gameloop();
        }

        
        private static void Gameloop()
        {
            while (true)
            {
                var kommando = _ui.Kommando_lesen();
                var spielstand = _ttt.Kommando_ausführen(kommando);
                _ui.Spielstand_anzeigen(spielstand);
            }
        }
    }
}
