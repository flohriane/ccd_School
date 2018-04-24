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
        public string Load_text(string filename)
        {
            var text = File.ReadAllText(filename);
            //var anzahl_wörter = File.ReadLines(filename).LongCount();
            var woerter = wörter_trennen(text);
            return text);
        }

        private string [] wörter_trennen (string text)
        {
            string [] wörter = text.Split("\n");

            return wörter;
        }
    }
}
