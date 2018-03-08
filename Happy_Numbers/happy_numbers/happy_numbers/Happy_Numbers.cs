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

        private static Dictionary<int, bool> Zahlenbereich_festlegen(int untergrenze, int obergrenze)
        {
            Dictionary<int, bool> zahlenbereich = new Dictionary<int, bool>();
            for (int zahl = untergrenze; zahl <= obergrenze; zahl++)
            {
                zahlenbereich.Add(zahl, false);
            }
            return zahlenbereich;
        }

        private static Dictionary<int, bool> Fröhliche_Zahlen_finden(Dictionary<int, bool> zahlenbereich)
        {
            foreach (int zahl in zahlenbereich.Keys.ToArray())
            {
                zahlenbereich[zahl] = Traurig_oder_Fröhlich(zahl);
            }
            return zahlenbereich;
        }

        private static bool Traurig_oder_Fröhlich(int zahl)
        {
            var summe_quadrierte_ziffern = Quadrierte_Summen_berechnen(zahl);

            if (summe_quadrierte_ziffern == 1) return true;
            if (summe_quadrierte_ziffern <= 4) return false;
            return Traurig_oder_Fröhlich(summe_quadrierte_ziffern); 
        }

        private static int Quadrierte_Summen_berechnen(int zahl)
        {
            var ziffern = Zahl_in_Ziffern_zerlegen(zahl);
            var quadrate = ziffern.Select(ziffer => ziffer * ziffer);
            return quadrate.Sum();
        }

        private static int[] Zahl_in_Ziffern_zerlegen(int zahl)
        {
            int[] ziffern = zahl.ToString()
                                .ToCharArray()
                                .Select(ziffer => ziffer.ToString())
                                .Select(int.Parse)
                                .ToArray();                    
            return ziffern;
        }

        private static List<int> Fröhliche_Zahlen_extrahieren(Dictionary<int,bool> zahlenbereich)
        {
            List<int> happy_numbers = zahlenbereich.Where(kriterium => kriterium.Value == true)
                                                   .Select(zahl => zahl.Key)
                                                   .ToList();
            return happy_numbers;
        }
    }
}
