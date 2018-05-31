using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    public class UI
    {
        public string Kommando_lesen()
        {
            Console.Write("\nKommando: ");
            return Console.ReadLine();
        }

        public void Spielfeld_ausgeben(string [,] spielfeld)
        {
            for (int zeile = 0; zeile < 6; zeile++)
            {
                for (int spalte = 0; spalte < 6; spalte++)
                {
                    Console.Write(spielfeld[zeile, spalte]);
                }
                Console.WriteLine();
            }
        }

        public string Gewinner_ausgeben(string spieler, string kommando)
        {
            if (spieler == "X" || spieler == "O")
            {
                Console.WriteLine("Spieler {0} hat gewonnen", spieler);
                return "ende";
            }
            else if (spieler == "unentschieden")
            {
                Console.WriteLine(spieler);
                return "ende";
            }
            else return kommando;
        }

        public void Programm_beenden()
        {
            Console.WriteLine("das Programm wird beendet");
        }
    }
}
