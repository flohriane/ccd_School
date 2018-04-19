using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    class UI
    {
        public string Monat_Jahr_einlesen()
        {
            return Console.ReadLine(); // ToDo ersetzen durch Programmaufruf aus cmd Zeile
        }

        public void Kalender_ausgeben(List<string> kalender)
        {
            for (int zeile = 0; zeile < kalender.Count; zeile++)
            {
                Console.WriteLine(kalender[zeile]);
            }

            Console.ReadKey();
        }
    }
}
