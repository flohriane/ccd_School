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
            return Fröhliche_destillieren(zahlenbereich);
        }

        private static void Zahlen_klassifizieren(Dictionary<int, bool> zahlenbereich)
        {
            foreach(var zahl in zahlenbereich.Keys)
                zahlenbereich[zahl] = Zahl_klassifizieren(zahl);
        }

        internal static Dictionary <int, bool> Zahlenbereich_festlegen (int untergrenze, int obergrenze)
        {
            Dictionary<int, bool> zahlenbereich = new Dictionary<int, bool>();
            for (int i = untergrenze; i <= obergrenze; i++)
                zahlenbereich[i] = false;
            return zahlenbereich;
        }

        static bool Zahl_klassifizieren(int zahl)
        {
            var ziffern = Zahl_in_Ziffern_zerlegen(zahl);  
            var ergebnis = Ziffern_im_Quadrat_summieren(ziffern);

            bool gekennzeichnete_fröhliche_Zahl = true;

            // Ergebnis prüfen
            if (ergebnis == 1)
            {
                gekennzeichnete_fröhliche_Zahl = true;
            }
            else if (ergebnis == 4)
            {
                gekennzeichnete_fröhliche_Zahl = false;
            }
            else
            {
                ergebnis = Ziffern_im_Quadrat_summieren(ziffern); // ich weiß, dass das eigentlich ein NOGO ist !!!
            }

            return gekennzeichnete_fröhliche_Zahl;
        }

        static List<int> Zahl_in_Ziffern_zerlegen(int zahl)
        {
            List<int> ziffern = new List<int>();
            for (int i = 1; i <= ziffern.Count; i++)
            {
                    ziffern.Add(i);
            }
            return ziffern;
        }

        static int Ziffern_im_Quadrat_summieren(List<int> ziffern)
        {
            int ergebnis = 0;
            for (int i = 1; i <= ziffern.Count; i++)
            {
                ergebnis = ergebnis + (ziffern[i]^2);
            }
            return ergebnis;
        }

        static List<int> Fröhliche_destillieren(Dictionary<int, bool> zahlenbereich)
        {
            List <int> fröhliche_Zahlen = new List <int>();
            for (int zahl = 1; zahl <= zahlenbereich.Count; zahl++)
            {
                if (zahlenbereich[zahl] == true)
                {
                    fröhliche_Zahlen.Add(zahl);
                }
            }
            return fröhliche_Zahlen;
        }
    }
}
