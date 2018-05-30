using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tictactoe;
using NUnit.Framework;

namespace tictactoe_tests
{
    [TestFixture]
    class TicTacToe_Tests
    {
        [Test]
        public void Kommando_test()
        {
            var ergebnis = TicTacToe.Kommando_ausführen(TicTacToe.Spielfeld_neu(), "a0", "X");
            Assert.AreEqual(ergebnis[1, 1], "X");
        }

        [Test]
        public void Gewinner_test()
        {
            var spielfeld = new string[6,6];
            spielfeld[1, 1] = "X";
            spielfeld[1, 3] = "X";
            spielfeld[1, 5] = "X";

            var ergebnis = TicTacToe.Gewinner_ermitteln(spielfeld, "X");
            Assert.AreEqual(ergebnis, "X");

            spielfeld[1, 5] = "O";
            spielfeld[3, 1] = "O";
            spielfeld[3, 3] = "O";
            spielfeld[3, 5] = "X";
            spielfeld[5, 1] = "X";
            spielfeld[5, 3] = "O";
            spielfeld[5, 5] = "X";

            ergebnis = TicTacToe.Gewinner_ermitteln(spielfeld, "X");
            Assert.AreEqual(ergebnis, "unentschieden");

            spielfeld[5, 5] = " ";
            ergebnis = TicTacToe.Gewinner_ermitteln(spielfeld, "O");
            Assert.AreEqual(ergebnis, "");
        }

        [Test]
        public void spieler_test()
        {
            var spieler = TicTacToe.Spieler_festlegen("neu", "A");
            Assert.AreEqual(spieler, "X");

            spieler = TicTacToe.Spieler_festlegen("A1", "X");
            Assert.AreEqual(spieler, "O");
        }
    }
}
