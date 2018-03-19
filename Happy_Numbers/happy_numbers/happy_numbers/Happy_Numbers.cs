using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_numbers
{
    public class Happy_Numbers
    {
        public static List<int> Zahlenliste_erstellen(int untergrenze, int obergrenze)
        {
            var zahlenbereich = Zahlenbereich_festlegen(untergrenze, obergrenze);
            zahlenbereich = Fröhliche_Zahlen_finden(zahlenbereich);
            var happy_numbers = Fröhliche_Zahlen_extrahieren(zahlenbereich);
            return happy_numbers;
        }

        internal static Dictionary<int, bool> Zahlenbereich_festlegen(int untergrenze, int obergrenze)
        {
            Dictionary<int, bool> zahlenbereich = new Dictionary<int, bool>();
            for (int zahl = untergrenze; zahl <= obergrenze; zahl++)
            {
                zahlenbereich.Add(zahl, false);
            }
            return zahlenbereich;

            // TODO warum funktioniert das nicht ?
            // Dictionary bleibt leer !   
            //return zahlenbereich.Where(zahl => zahl.Key >= untergrenze-1)   
            //                    .Where(zahl => zahl.Key < obergrenze)
            //                    .ToDictionary(zahl => zahl.Key, kriterium => false);
        }

        private static Dictionary<int, bool> Fröhliche_Zahlen_finden(Dictionary<int, bool> zahlenbereich)
        {
            return zahlenbereich.ToDictionary(kv => kv.Key, kv => Fröhlichkeit_ermitteln_rec(kv.Key));
        }

        private static bool Fröhlichkeit_ermitteln_rec(int zahl)
        {
            if (zahl == 1) return true;
            if (zahl <= 4) return false;
            
            zahl = Transformieren(zahl);
            return Fröhlichkeit_ermitteln_rec(zahl); 
        }

        private static int Transformieren(int zahl)
        {
            var ziffern = zahl.ToString() // REPL
                                .ToCharArray()
                                .Select(ziffer => ziffer.ToString())
                                .Select(int.Parse)
                                .ToArray();
            var quadrate = ziffern.Select(ziffer => ziffer * ziffer);
            return quadrate.Sum();
        }

        private static List<int> Fröhliche_Zahlen_extrahieren(Dictionary<int,bool> zahlenbereich)
        {
            return zahlenbereich.Where(kriterium => kriterium.Value == true)
                                .Select(zahl => zahl.Key)
                                .ToList();
        }
    }
}
