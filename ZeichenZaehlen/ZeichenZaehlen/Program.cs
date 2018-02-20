using System;
using System.Collections.Generic;

namespace Zeichen_zaehlen
{
    class Counter
    {
        // Integration
        public static Dictionary<char, int> ZaehleZeichen(string eingabe)
        {
            char[] zeichen = TrenneTextInZeichen(eingabe);
            Dictionary<char, int> dictZeichen = Zeichenhäufigkeit_bestimmen(zeichen);
            Histogramm_ausgeben(dictZeichen);
            return dictZeichen;
        }

        static char[] TrenneTextInZeichen(string eingabe)
        {
            char[] zeichen = new char[eingabe.Length];

            for (int i = 0; i < eingabe.Length; i++)
            {
                zeichen[i] = Convert.ToChar(eingabe[i]); // konvertiert nur das erste Zeichen in ein Unicode-Zeichen
            }

            return zeichen;
        }


        static Dictionary<char, int> Zeichenhäufigkeit_bestimmen(char[] zeichen)
        {
            Dictionary<char, int> dictZeichen = new Dictionary<char, int>();

            // Dicitonary dictZeichen wird gefüllt, indem das eindimensionale Array zeichen ausgelesen wird
            foreach (var z in zeichen)
            {
                if (dictZeichen.ContainsKey(z)) // wenn das Zeichen schon vorkommt, Zähler um 1 erhöhen
                {
                    dictZeichen[z] += 1;
                }
                else // ansonsten neuer Eintrag mit Zähler = 1 
                {
                    dictZeichen.Add(z, 1);
                }
            }

            return dictZeichen;
        }

        static void Histogramm_ausgeben(Dictionary<char, int> dictZeichen)
        {
            // Dictionary dictSingulaerZeichen wird gefüllt, indem das Dictionary dictZeichen ausgelesen wird 
            // und nur die eindeutigen Einträge übernommen werden
            foreach (KeyValuePair<char, int> wertePaar in dictZeichen) {
                    Console.WriteLine("{0} : {1}", wertePaar.Key, wertePaar.Value); // zum testen
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var eingabe = "Das ist mein Dext";

            var d = Counter.ZaehleZeichen(eingabe);
            Assert(d['D'] == 2);
        }
        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed!");
        }
    }
}
