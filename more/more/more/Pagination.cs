using System;
using System.Collections.Generic;

namespace more
{
    class Pagination
    {
        public static Seite[] Convert(string text, int pageLen)
        {
            var zeilen = Zeilen_erzeugen(text); // Yay!
            return Seiten_erzeugen(zeilen, pageLen); // Supi!
        }

        private static string[] Zeilen_erzeugen(string text) {
            return text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        }
        
        private static Seite[] Seiten_erzeugen(string[] zeilen, int pageLen)
        {
            var seiten = new List<Seite>();
            
            var seitenzeilen = new List<string>();
            foreach (var z in zeilen) {
                seitenzeilen.Add(z);
                if (seitenzeilen.Count == pageLen) {
                    seiten.Add(new Seite{Zeilen = seitenzeilen.ToArray()});
                    seitenzeilen = new List<string>();
                }
            }
            if (seitenzeilen.Count > 0)
                seiten.Add(new Seite{Zeilen = seitenzeilen.ToArray()});
            
            return seiten.ToArray();
        }
    }
}