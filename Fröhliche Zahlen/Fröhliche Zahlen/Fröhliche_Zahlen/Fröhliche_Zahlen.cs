using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zahlenakrobatik
{
    public class Fröhliche_Zahlen
    { 
        public static List<int> Zahlen_verarbeiten(int untergrenze, int obergrenze) {
            var zahlenbereich = Zahlenbereich_festlegen(untergrenze, obergrenze);
            Zahlen_klassifizieren(zahlenbereich);
            return Markierte_destillieren(zahlenbereich);
        }

        private static void Zahlen_klassifizieren(Dictionary<int, bool> zahlenbereich)
        {
            foreach (var zahl in zahlenbereich.Keys.ToArray())
                zahlenbereich[zahl] = Stimmungsklassifizierung.Fröhlichkeit_bestimmen(zahl);
        }

        private static Dictionary <int, bool> Zahlenbereich_festlegen (int untergrenze, int obergrenze)
        {
            Dictionary<int, bool> zahlenbereich = new Dictionary<int, bool>();
            for (int i = untergrenze; i <= obergrenze; i++)
                zahlenbereich[i] = false;
            return zahlenbereich;
        }

        private static List<int> Markierte_destillieren(Dictionary<int, bool> zahlenbereich)
        {
            List <int> fröhliche_Zahlen = new List <int>();
            foreach (var zahl in zahlenbereich.Keys)
            {
                if (zahlenbereich[zahl])
                    fröhliche_Zahlen.Add(zahl);
            }
            return fröhliche_Zahlen;
        }
    }
}
