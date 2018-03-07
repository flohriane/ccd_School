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

        private static void Fröhliche_Zahlen_finden(Dictionary<int,bool> zahlenbereich)
        {
            foreach (int zahl in zahlenbereich.Keys.ToArray())
            {
                zahlenbereich[zahl] = Traurig_oder_Fröhlich(zahl);
            }

        }

        private static bool Traurig_oder_Fröhlich(int zahl)
        {
            var ziffern = Zahl_in_Ziffern_zerlegen(zahl);
            // TODO Ziffern im Quadarat addieren bis 1 oder 4 als Ergebnis kommt
            return false;
        }

        internal static int[] Zahl_in_Ziffern_zerlegen(int zahl)
        {
            int[] ziffern = new int[zahl.ToString().Length];

            for (int i = 0; i < zahl.ToString().Length; i++)
            {
                ziffern[i] = Convert.ToInt32(zahl.ToString().Substring(i,1));
            }
            return ziffern;
        }
    }
}
