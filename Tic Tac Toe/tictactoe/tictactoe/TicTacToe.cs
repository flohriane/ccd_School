using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tictactoe
{
    public static class TicTacToe
    {
        public static string[,] Kommando_ausführen(string [,] spielfeld, string kommando,string spieler)
        {
            var ui = new UI();

            switch (kommando)
            {
                case "ende":
                    ui.Programm_beenden();
                    return spielfeld;
                case "neu":
                    spielfeld = Spielfeld_neu();
                    return spielfeld;
                default:
                    spielfeld = Spielfeld_aktualisieren(spielfeld, kommando, spieler);
                    return spielfeld;
            }
        }
        public static string[,] Spielfeld_neu() 
        {
            var spielfeld = new string[6, 6] 
            {            
                {" ","A"," ","B"," ","C"},
                {"0"," ","|"," ","|"," "},
                {" ","-","+","-","+","-"},
                {"1"," ","|"," ","|"," "},
                {" ","-","+","-","+","-"},
                {"2"," ","|"," ","|"," "}
            };
            return spielfeld;
        }

        private static string[,] Spielfeld_aktualisieren(string [,] spielfeld, string kommando, string spieler)
        {
            switch (kommando.ToLower())
            {
                case "a0":
                    spielfeld[1,1] = (spieler);
                    break;
                case "b0":
                    spielfeld[1,3] = (spieler);
                    break;
                case "c0":
                    spielfeld[1,5] = (spieler);
                    break;
                default:
                    break;
            }

            switch (kommando.ToLower())
            {
                case "a1":
                    spielfeld[3,1] = (spieler);
                    break;
                case "b1":
                    spielfeld[3,3] = (spieler);
                    break;
                case "c1":
                    spielfeld[3,5] = (spieler);
                    break;
                default:
                    break;
            }

            switch (kommando.ToLower())
            {
                case "a2":
                    spielfeld[5,1] = (spieler);
                    break;
                case "b2":
                    spielfeld[5,3] = (spieler);
                    break;
                case "c2":
                    spielfeld[5,5] = (spieler);
                    break;
                default:
                    break;
            }

            return spielfeld;
        }

        public static string Spieler_festlegen(string kommando, string spieler)
        {
            if (kommando == "neu") return "X";
            else if (spieler == "X") return "O";
            else return "X";
        }

        public static string Gewinner_ermitteln(string[,] spielfeld, string spieler)
        {
            if      ((spielfeld[1, 1] == "X" && spielfeld[1, 3] == "X" && spielfeld[1, 5] == "X") ||    // A0 B0 C0
                     (spielfeld[3, 1] == "X" && spielfeld[3, 3] == "X" && spielfeld[3, 5] == "X") ||    // A1 B1 C1
                     (spielfeld[5, 1] == "X" && spielfeld[5, 3] == "X" && spielfeld[5, 5] == "X") ||    // A2 B2 C2
                     (spielfeld[1, 1] == "X" && spielfeld[3, 1] == "X" && spielfeld[5, 1] == "X") ||    // A0 A1 A2
                     (spielfeld[1, 3] == "X" && spielfeld[3, 3] == "X" && spielfeld[5, 3] == "X") ||    // B0 B1 B2
                     (spielfeld[1, 5] == "X" && spielfeld[3, 5] == "X" && spielfeld[5, 5] == "X") ||    // C0 C1 C2
                     (spielfeld[1, 1] == "X" && spielfeld[3, 3] == "X" && spielfeld[5, 5] == "X") ||    // A0 B1 C2
                     (spielfeld[5, 1] == "X" && spielfeld[3, 3] == "X" && spielfeld[1, 5] == "X"))      // A2 B1 C0
                return "X";

            else if ((spielfeld[1, 1] == "O" && spielfeld[1, 3] == "O" && spielfeld[1, 5] == "O") ||    // A0 B0 C0
                     (spielfeld[3, 1] == "O" && spielfeld[3, 3] == "O" && spielfeld[3, 5] == "O") ||    // A1 B1 C1
                     (spielfeld[5, 1] == "O" && spielfeld[5, 3] == "O" && spielfeld[5, 5] == "O") ||    // A2 B2 C2
                     (spielfeld[1, 1] == "O" && spielfeld[3, 1] == "O" && spielfeld[5, 1] == "O") ||    // A0 A1 A2
                     (spielfeld[1, 3] == "O" && spielfeld[3, 3] == "O" && spielfeld[5, 3] == "O") ||    // B0 B1 B2
                     (spielfeld[1, 5] == "O" && spielfeld[3, 5] == "O" && spielfeld[5, 5] == "O") ||    // C0 C1 C2
                     (spielfeld[1, 1] == "O" && spielfeld[3, 3] == "O" && spielfeld[5, 5] == "O") ||    // A0 B1 C2
                     (spielfeld[5, 1] == "O" && spielfeld[3, 3] == "O" && spielfeld[1, 5] == "O"))      // A2 B1 C0
                return "O";

            else if (spielfeld[1, 1] != " " && spielfeld[1, 3] != " " && spielfeld[1, 5] != " " &&
                     spielfeld[3, 1] != " " && spielfeld[3, 3] != " " && spielfeld[3, 5] != " " &&
                     spielfeld[5, 1] != " " && spielfeld[5, 3] != " " && spielfeld[5, 5] != " ")
                return "unentschieden";

            else return "";
        }
    }
}
