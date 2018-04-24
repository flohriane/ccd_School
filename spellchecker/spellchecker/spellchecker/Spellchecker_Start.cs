using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    public class Spellchecker_Start
    {
        public static List<string> Wörter_prüfen(string[] wörter_Datei, string[] eingabe_Konsole)
        {
            var array_größe = eingabe_Konsole.Length;

            var fehlerliste = Fehler_finden();
            return fehlerliste;
        }

        internal static List<string> Fehler_finden()
        {
            var fehlerliste = new List<string>();
            return fehlerliste;
        }
    }
}
