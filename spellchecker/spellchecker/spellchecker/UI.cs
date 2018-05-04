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
            for (int i = 0; i < fehler.Count; i++)
            {
                Console.WriteLine(fehler[i]);
            }
            Console.ReadKey();
        }
    }
}
