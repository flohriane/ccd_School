using System;
using NUnit.Framework;
using ttt.contracts.daten;

namespace ttt.schiedsrichter.tests
{
    [TestFixture]
    public class Akzeptanztest
    {
        [Test]
        public void Spielende_mit_Gewinn_in_Zeile()
        {
            var sut = new Schiedsrichter();

            var spiel = new Spiel();
            var result = Spielfortschritt.Läuft;
            spiel.Spielbrett[1, 0] = Spiel.Spielfeldzustände.X;
            spiel.Spielbrett[1, 1] = Spiel.Spielfeldzustände.X;
            spiel.Spielbrett[1, 2] = Spiel.Spielfeldzustände.X;
            
            sut.SpielstandBestimmen(spiel, fortschritt => result = fortschritt, _ => Assert.Fail());
            
            Assert.AreEqual(result, Spielfortschritt.XGewinnt);
        }
        
        
        [Test]
        public void Spielende_mit_Gewinn_in_Spalte()
        {
            var sut = new Schiedsrichter();

            var spiel = new Spiel();
            var result = Spielfortschritt.Läuft;
            spiel.Spielbrett[0, 2] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[1, 2] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[2, 2] = Spiel.Spielfeldzustände.O;
            
            sut.SpielstandBestimmen(spiel, fortschritt => result = fortschritt, _ => Assert.Fail());
            
            Assert.AreEqual(result, Spielfortschritt.OGewinnt);
        }
        
        [Test]
        public void Spielende_mit_Gewinn_in_Diagonale()
        {
            var sut = new Schiedsrichter();

            var spiel = new Spiel();
            var result = Spielfortschritt.Läuft;
            spiel.Spielbrett[0, 0] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[1, 1] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[2, 2] = Spiel.Spielfeldzustände.O;
            
            sut.SpielstandBestimmen(spiel, fortschritt => result = fortschritt, _ => Assert.Fail());
            
            Assert.AreEqual(result, Spielfortschritt.OGewinnt);
        }
        
        
        [Test]
        public void Spielende_durch_Unentschieden()
        {
            var sut = new Schiedsrichter();

            var spiel = new Spiel();
            var result = Spielfortschritt.Läuft;
            spiel.Spielbrett[0, 0] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[0, 1] = Spiel.Spielfeldzustände.X;
            spiel.Spielbrett[0, 2] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[1, 0] = Spiel.Spielfeldzustände.X;
            spiel.Spielbrett[1, 1] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[1, 2] = Spiel.Spielfeldzustände.X;
            spiel.Spielbrett[2, 0] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[2, 1] = Spiel.Spielfeldzustände.O;
            spiel.Spielbrett[2, 2] = Spiel.Spielfeldzustände.X;
            
            sut.SpielstandBestimmen(spiel, fortschritt => result = fortschritt, _ => Assert.Fail());
            
            Assert.AreEqual(result, Spielfortschritt.Unentschieden);
        }
        
        
        [Test]
        public void Spiel_läuft_weiter_mit_Spielerwechsel()
        {
            var sut = new Schiedsrichter();
            var spiel = new Spiel();
            
            var result = new Spiel();
            spiel.Spielbrett[0, 1] = Spiel.Spielfeldzustände.X;
            
            Assert.AreEqual(Spiel.Spieler.X, spiel.AktuellerSpieler);
            
            sut.SpielstandBestimmen(spiel, _ => Assert.Fail(), aktualisiertesSpiel => result = aktualisiertesSpiel);
            Assert.AreEqual(Spiel.Spieler.O, result.AktuellerSpieler);
            
            sut.SpielstandBestimmen(result, _ => Assert.Fail(), aktualisiertesSpiel => result = aktualisiertesSpiel);
            Assert.AreEqual(Spiel.Spieler.X, result.AktuellerSpieler);
        }
    }
}