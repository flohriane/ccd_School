using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    public class Spellchecker_Start
    {

        public static List<string> Wörter_auf_Fehler_überprüfen(string[] wörter, string[] prüfwörter)
        {
            var fehlerliste = new List<string>();

            // einfachere Lösung mit Lambdafunktionen ???

            foreach (string pw in prüfwörter)
            {
                var zähler = 0;
                foreach (string w in wörter)
                {
                    if (w != pw)
                    {
                        zähler++;
                    }
                }

                if (zähler == wörter.Count()) // kein gleiches Wort gefunden
                {
                    fehlerliste.Add(pw);
                }
            }
            return fehlerliste;
        }
    }
}
