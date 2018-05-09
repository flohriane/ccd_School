
namespace spellchecker
{
    class CLI
    {
        private readonly string[] _args;
        public CLI(string[] args)
        {
            _args = args;
        }

        public string dateiname => _args[0];
    }
}
