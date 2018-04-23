using System;

namespace kalender
{
    static class Kalender
    {
        public static int Anzahl_Tage_im_Monat_berechnen(int jahr, int monat_zahl) {
            var schaltjahr = Schaltjahr_pruefen(jahr);
            var anzahl_tage = Anzahl_Tage_ermitteln(schaltjahr, monat_zahl);
            return anzahl_tage;
        }
        
        
        private static bool Schaltjahr_pruefen(int jahr)
        {
            if (DateTime.IsLeapYear(jahr))
            {
                return true;
            }
            else return false;
        }
        
        
        private static int Anzahl_Tage_ermitteln(bool schaltjahr, int monat)
        {
            switch (monat)
            {
                case 1:
                    return 31;
                case 2:
                    if (schaltjahr) return 29;
                    else return 28;
                case 3:
                    return 31;
                case 4:
                    return 30;
                case 5:
                    return 31;
                case 6:
                    return 30;
                case 7:
                    return 31;
                case 8:
                    return 31;
                case 9:
                    return 30;
                case 10:
                    return 31;
                case 11:
                    return 30;
                case 12:
                    return 31;
                default:
                    return 0;
            }
        }
        
        
        public static string Erster_Wochentag_ermitteln(int jahr, int monat)
        {
            DateTime tag = new DateTime(jahr, monat, 1);
            var wochentag = tag.DayOfWeek;

            return Convert.ToString(wochentag);
        }
    }
}