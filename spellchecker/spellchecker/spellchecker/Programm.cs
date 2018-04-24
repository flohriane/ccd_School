using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    class Programm
    {
        static void Main(string[] args)
        {
            var ui = new UI();
            var fs = new Filesystem();

            var woerter_Datei = fs.Load_text("");
            Spellchecker_Start.Wörter_prüfen(woerter_Datei, args);       
        }       
    }
}
