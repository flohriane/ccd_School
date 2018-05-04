using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace spellchecker
{
    class Filesystem
    {
        public string[] Wortlistendatei_holen(string dateiname)
        {
            return File.ReadAllLines(dateiname);
        }
    }
}
