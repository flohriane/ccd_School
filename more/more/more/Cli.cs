namespace more
{
    class Cli // Command Line Interface
    {
        private readonly string[] _args;
        public Cli(string[] args) {
            _args = args;
        }

        public string Filename => _args[0];
        public int PageLen => 5; //_args.Length > 1 ? int.Parse(_args[1]) : 20;
    }
}