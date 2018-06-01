using System;
using System.Linq;
using ttt.contracts;
using ttt.contracts.daten;

namespace ttt.schiedsrichter
{
    public class Schiedsrichter : ISchiedsrichter
    {
        public void SpielstandBestimmen(Spiel spiel, Action<Spielfortschritt> onSpielende, Action<Spiel> onSpielLäuftWeiter) {
            SpielendePrüfen(spiel,
                onSpielende,
                onSpielLäuftWeiter: () => {
                    spiel.AktuellerSpieler = SpielerWechseln(spiel.AktuellerSpieler);
                    onSpielLäuftWeiter(spiel);
                });
        }

        private void SpielendePrüfen(Spiel spiel, Action<Spielfortschritt> onSpielende, Action onSpielLäuftWeiter)
        {
            //TODO: richtige gewinnermittlung implementieren
            if (spiel.Spielbrett[1, 1] == Spiel.Spielfeldzustände.X)
                onSpielende(Spielfortschritt.XGewinnt);
            else if (spiel.Spielbrett[2, 2] == Spiel.Spielfeldzustände.O)
                onSpielende(Spielfortschritt.OGewinnt);
            else {
                foreach(var r in spiel.Reihen)
                    if (r.Any(f => f == Spiel.Spielfeldzustände.Frei)) {
                        onSpielLäuftWeiter();
                        return;
                    }
                onSpielende(Spielfortschritt.Unentschieden);
            }
        }

        private Spiel.Spieler SpielerWechseln(Spiel.Spieler aktuellerSpieler) {
            return aktuellerSpieler == Spiel.Spieler.X ? Spiel.Spieler.O : Spiel.Spieler.X;
        }
    }
}