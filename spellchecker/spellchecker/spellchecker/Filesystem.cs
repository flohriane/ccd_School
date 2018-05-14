using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace spellchecker
{
    class Filesystem
    {
        public string Eingabetext_holen(string dateiname)
        {
            return File.ReadAllText(dateiname);
        }

        public HashSet<string> Wortliste_holen(string dateiname)
        {
            var lexikoneinträge = File.ReadAllLines(dateiname);
            return new HashSet<string>(lexikoneinträge);
        }
    }
}
