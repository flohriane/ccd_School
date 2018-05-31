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
            var spielfeld = new string[6, 6];

            var ergebnis = TicTacToe.Kommando_ausführen(spielfeld, "neu", "X");
            Assert.AreEqual(ergebnis[0, 1], "A");
            Assert.AreEqual(ergebnis[1, 0], "0");
            Assert.AreEqual(ergebnis[1, 1], " ");
            Assert.AreEqual(ergebnis[4, 4], "+");
            Assert.AreEqual(ergebnis[5, 4], "|");

            ergebnis = TicTacToe.Kommando_ausführen(spielfeld, "a0", "X");
            Assert.AreEqual(ergebnis[1, 1], "X");

            ergebnis = TicTacToe.Kommando_ausführen(spielfeld, "c2", "O");
            Assert.AreEqual(ergebnis[5, 5], "O");

            ergebnis = TicTacToe.Kommando_ausführen(spielfeld, "ende", "X");
            Assert.AreEqual(ergebnis[5, 5], "O");
            Assert.AreEqual(ergebnis[1, 1], "X");

        }

        [Test]
        public void Gewinner_test()
        {
            var spielfeld = new string[6,6];
            spielfeld[1, 1] = "X";
            spielfeld[1, 3] = "X";
            spielfeld[1, 5] = "X";

            var gewinner = TicTacToe.Gewinner_ermitteln(spielfeld, "X");
            Assert.AreEqual(gewinner, "X");

            spielfeld[1, 5] = "O";
            spielfeld[3, 3] = "O";
            spielfeld[5, 1] = "O";

            gewinner = TicTacToe.Gewinner_ermitteln(spielfeld, "O");
            Assert.AreEqual(gewinner, "O");

            spielfeld[1, 5] = "O";
            spielfeld[3, 1] = "O";
            spielfeld[3, 3] = "O";
            spielfeld[3, 5] = "X";
            spielfeld[5, 1] = "X";
            spielfeld[5, 3] = "O";
            spielfeld[5, 5] = "X";

            gewinner = TicTacToe.Gewinner_ermitteln(spielfeld, "X");
            Assert.AreEqual(gewinner, "unentschieden");

            spielfeld[5, 5] = " ";
            gewinner = TicTacToe.Gewinner_ermitteln(spielfeld, "O");
            Assert.AreEqual(gewinner, "");
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
