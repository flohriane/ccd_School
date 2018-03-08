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
            Fröhliche_Zahlen_finden(zahlenbereich);

            // Dummy List
            var happy_numbers = new List<int>();
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
        }

        private static void Fröhliche_Zahlen_finden(Dictionary<int, bool> zahlenbereich)
        {
            foreach (int zahl in zahlenbereich.Keys.ToArray())
            {
                zahlenbereich[zahl] = Traurig_oder_Fröhlich(zahl);
            }

        }

        internal static bool Traurig_oder_Fröhlich(int zahl)
        {
            var summe_quadrierte_ziffern = Quadrierte_Summen_berechnen(zahl);

            if (summe_quadrierte_ziffern == 1) return true;
            if (summe_quadrierte_ziffern <= 4) return false;
            return Traurig_oder_Fröhlich(summe_quadrierte_ziffern); // Rekursion
        }

        internal static int Quadrierte_Summen_berechnen(int zahl)
        {
            var ziffern = Zahl_in_Ziffern_zerlegen(zahl);
            var quadrate = ziffern.Select(ziffer => ziffer * ziffer);
            return quadrate.Sum();
        }

        internal static int[] Zahl_in_Ziffern_zerlegen(int zahl)
        {
            int[] ziffern = zahl.ToString()
                                .ToCharArray()
                                .Select(ziffer => ziffer.ToString())
                                .Select(int.Parse)
                                .ToArray();                    
            return ziffern;
        }
    }
}
