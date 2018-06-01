using System;
using System.Collections.Generic;

namespace ttt.contracts.daten
{
    public class Spiel
    {
        public enum Spielfeldzustände { Frei, X, O }
        public enum Spieler { X, O }
        
        
        public Spielfeldzustände[,] Spielbrett = new Spielfeldzustände[3,3];
        public Spieler AktuellerSpieler = Spieler.X;

        
        public void Starten() {
            throw new NotImplementedException();
        }

        
        public void SpielsteinSetzen(Spielbrettkoordinate koordinate) {
            throw new NotImplementedException();
        }


        public IEnumerable<Spielfeldzustände[]> Reihen
        {
            get {
                yield return Zeile(0);
                yield return Zeile(1);
                yield return Zeile(2);
                yield return Spalte(0);
                yield return Spalte(1);
                yield return Spalte(2);
                yield return Diagonale(0, 1);
                yield return Diagonale(2, -1);
            }
        }

        private Spielfeldzustände[] Zeile(int zeile)
            => new[] {this.Spielbrett[zeile, 0], this.Spielbrett[zeile, 1], this.Spielbrett[zeile, 2]};
        private Spielfeldzustände[] Spalte(int spalte)
            => new[] {this.Spielbrett[0,spalte], this.Spielbrett[1,spalte], this.Spielbrett[2,spalte]};
        private Spielfeldzustände[] Diagonale(int zeile, int deltaZeile)
            => new[] {this.Spielbrett[zeile, 0], this.Spielbrett[zeile+deltaZeile, 1], this.Spielbrett[zeile+deltaZeile, 2]};
    }
}