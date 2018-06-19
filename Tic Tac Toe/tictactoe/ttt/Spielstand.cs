namespace ttt
{
    public class Spielstand // immutable value object
    {
        public Spielstand(string spielfeld, string fortschritt, string aktuellerSpieler) {
            this.Spielfeld = spielfeld;
            this.Fortschritt = fortschritt;
            this.AktuellerSpieler = aktuellerSpieler;
        }
        
        public string Spielfeld { get; }
        public string Fortschritt { get; }
        public string AktuellerSpieler { get; }
    }
}