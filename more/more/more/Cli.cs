namespace more
{
    class Cli // Command Line Interface
    {
        private readonly string[] _args;
        // Parameter-Konstruktor wird aufgerufen, wenn eine Instanz von class CLI erstellt wird  
        // dem Attribut _args wird der Inhalt der Command Line zugewiesen 
        public Cli(string[] args)
        {                 
            _args = args;
        }

        public string Filename => _args[0];         // 
        public int PageLen => _args.Length > 1 ? int.Parse(_args[1]) : 20;
    }
}