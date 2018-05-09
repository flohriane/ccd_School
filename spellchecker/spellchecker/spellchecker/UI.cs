using System;
using System.Collections.Generic;

namespace spellchecker
{
    class UI
    {
         public void Fehlerliste_ausgeben(List<string> fehler)
        {
            for (int i = 0; i < fehler.Count; i++)
            {
                Console.WriteLine(fehler[i]);
            }
            //Console.ReadKey();
        }
    }
}
