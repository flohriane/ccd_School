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
            //TODO Methode, um aus Zahlenbereich einzelne Zahlen in Ziffern zu zerlegen
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
    }
}
