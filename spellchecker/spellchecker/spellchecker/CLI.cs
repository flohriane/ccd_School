using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    class CLI
    {
        private readonly string[] _args;
        public CLI(string[] args)
        {
            _args = args;
        }

        public string Dateiname => _args[0];

        public List<string> Prüfwörter_von_Konsole_holen()
        {
            var prüfwörter = new List<string>();

            for (int pw = 1; pw < _args.Length; pw++) // Liste aus _args ohne Filename erstellen
            {
                prüfwörter.Add(_args[pw]);
            }
            return prüfwörter;
        }
    }
}
