using System;
using ttt.contracts.daten;

namespace ttt.contracts
{
    public interface ISchiedsrichter
    {
        void SpielstandBestimmen(Spiel spiel, Action<Spielfortschritt> onSpielende, Action<Spiel> onSpielLäuftWeiter);
    }
}