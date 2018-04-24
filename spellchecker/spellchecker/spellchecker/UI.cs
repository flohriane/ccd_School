using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    class UI
    {
        public void Fehlerliste_ausgeben(List<string> fehler)
        {
            for (int eintrag = 0; eintrag < fehler.Count; eintrag++)
            {
                Console.WriteLine(fehler[eintrag]);
            }

            Console.ReadKey();
        }
    }
}
