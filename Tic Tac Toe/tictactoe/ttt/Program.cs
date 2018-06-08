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
            var schiedsrichter = new Schiedsrichter();
            var ttt = new TicTacToe(spiel, schiedsrichter);
            var app = new App(ttt, ui);

            app.Run();
        }
    }
}