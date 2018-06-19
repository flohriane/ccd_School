using System;
using System.Collections.Generic;
using ttt.contracts.daten;
using ttt.schiedsrichter;

namespace ttt
{
    public class TicTacToe
    {
        private readonly Spiel _spiel;
        private readonly Schiedsrichter _schiedsrichter;

        public TicTacToe(Spiel spiel, Schiedsrichter schiedsrichter) {
            _spiel = spiel;
            _schiedsrichter = schiedsrichter;
        }

        public Spielstand Starten() {
            _spiel.Starten();
            return Spiel_projizieren();
        }

        private Spielstand Spiel_projizieren()
        {
            throw new System.NotImplementedException();
        }


        public Spielstand Kommando_ausführen(string kommando)
        {
            switch (Parsen(kommando)) {
                case NeuKommando n:
                    _spiel.Starten();    
                    var spielstand = Spiel_projizieren();
                    return spielstand;
                case SetzenKommando s:
                    _spiel.SpielsteinSetzen(s.Koordinate);
                    // TODO: hier gehts weiter
                    _schiedsrichter.SpielstandBestimmen(_spiel,
                        onSpielende: fortschritt => {
                            
                        },
                        onSpielLäuftWeiter: spiel => {
                            
                        });
            }
        }


        abstract class Kommando {}
        class NeuKommando : Kommando {}
        class SetzenKommando : Kommando {
            public Spielbrettkoordinate Koordinate;
        } 
        
        private Kommando Parsen(string kommando) {
            if (kommando == "neu")
                return new NeuKommando();
            return new SetzenKommando {Koordinate = new Spielbrettkoordinate {Spalte = 0, Zeile = 0}};
        }
    }
}