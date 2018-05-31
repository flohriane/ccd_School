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
            var ui = new UI();

            var spieler = "X";
            var kommando = "neu";
            var spielfeld = TicTacToe.Spielfeld_neu();
            var gewinner = "";

             while (kommando != "ende" && gewinner == "")
            {
                ui.Spielfeld_ausgeben(spielfeld);
                kommando = ui.Kommando_lesen();

                spielfeld = TicTacToe.Kommando_ausführen(spielfeld, kommando, spieler);
                gewinner = TicTacToe.Gewinner_ermitteln(spielfeld, spieler);
                kommando = ui.Gewinner_ausgeben(gewinner, kommando);
                spieler = TicTacToe.Spieler_festlegen(kommando, spieler);
            }
        }
    }
}
