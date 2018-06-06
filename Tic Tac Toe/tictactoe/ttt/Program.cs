using ttt.contracts.daten;
using ttt.schiedsrichter;

namespace ttt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UI ui = new UI();
            Spiel spiel = new Spiel();
            Schiedsrichter schiedsrichter = new Schiedsrichter();
            Spielbrettkoordinate koordinate = new Spielbrettkoordinate();
            Spielfortschritt fortschritt = new Spielfortschritt();

            App.Run(spiel, ui);
        }
    }
}