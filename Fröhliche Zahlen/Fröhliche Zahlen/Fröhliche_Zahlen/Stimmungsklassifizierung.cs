using System.Linq;

namespace zahlenakrobatik
{
    internal class Stimmungsklassifizierung
    {
        public static bool Fröhlichkeit_bestimmen(int zahl)
        {
            var qq = Quadrierte_Quersumme_berechnen(zahl);
            if (qq == 1) return true;
            if (qq <= 4) return false;
            return Fröhlichkeit_bestimmen(qq);
        }

        private static int Quadrierte_Quersumme_berechnen(int zahl)
        {
            var ziffern = Zerlegen(zahl);
            var quadrate = ziffern.Select(z => z * z);
            return quadrate.Sum();
        }

        private static int[] Zerlegen(int zahl) {
            return zahl.ToString().ToCharArray()
                                  .Select(zch => zch.ToString())
                                  .Select(int.Parse)
                                  .ToArray();
        }
    }
}