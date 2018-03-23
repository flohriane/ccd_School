using System;
using System.Collections.Generic;

namespace more
{
    class PagewisePresentation
    {
        public void Display(string text, int pageLen)
        {
            var zeilen = Zeilen_erzeugen(text); // Yay!
            var seiten = Seiten_erzeugen(zeilen, pageLen); // Supi!
            Ausgeben(seiten);
        }

        internal string[] Zeilen_erzeugen(string text) {
            return text.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
        }
        
        private Seite[] Seiten_erzeugen(string[] zeilen, int pageLen)
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
        
        private void Ausgeben(Seite[] seiten)
        {
            for(var i=0; i<seiten.Length; i++){
                foreach(var z in seiten[i].Zeilen)
                    Console.WriteLine(z);

                if (i == seiten.Length-1) break;
                Console.WriteLine("---Press space to continue or ESC to quit---");
                var isEsc = Console.ReadKey(true).Key == ConsoleKey.Escape;
                if (isEsc) break;
            }
        }

        private struct Seite {
            public string[] Zeilen;
        }
    }
}