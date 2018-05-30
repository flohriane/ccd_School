using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            var spieler = "X";
            var kommando = "neu";
            var spielfeld = TicTacToe.Spielfeld_neu();
            var gewinner = "";

            while (kommando != "ende" && gewinner == "")
            {
                UI.Spielfeld_ausgeben(spielfeld);
                kommando = UI.Kommando_lesen();

                spielfeld = TicTacToe.Kommando_ausführen(spielfeld, kommando, spieler);
                gewinner = TicTacToe.Gewinner_ermitteln(spielfeld, spieler);
                kommando = UI.Gewinner_ausgeben(gewinner, kommando);
                spieler = TicTacToe.Spieler_festlegen(kommando, spieler);
            }
        }
    }
}
