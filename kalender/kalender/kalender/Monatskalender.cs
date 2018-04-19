using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    public class Monatskalender
    {
        public static List<string> Kalender_erstellen(string eingabe_monat_jahr)
        {
            var jahr = Jahr_ermitteln(eingabe_monat_jahr);

            var schaltjahr = Schaltjahr_pruefen(jahr);

            var monat_zahl = Monat_zahl_ermitteln(eingabe_monat_jahr);

            var monat_name = Monat_name_ermitteln(monat_zahl, jahr);

            var erster_wochentag = Erster_Wochentag_ermitteln(jahr, monat_zahl);

            var anzahl_tage = Anzahl_Tage_ermitteln(schaltjahr, monat_zahl);

            var kalender_zeile = Leerzeichen_schreiben(erster_wochentag);

            kalender_zeile = Tage_in_Zeile_schreiben(kalender_zeile, anzahl_tage);

            var kalender_liste = Kalender_formatieren(monat_name, kalender_zeile);

            return kalender_liste;
        }

        private static string Jahr_ermitteln(string eingabe_monat_jahr)
        {
            return eingabe_monat_jahr.Substring(eingabe_monat_jahr.Length - 4);
        }

        private static bool Schaltjahr_pruefen(string jahr)
        {
            if (DateTime.IsLeapYear(Convert.ToInt32(jahr)))
            {
                return true;
            }
            else return false;
        }

        private static string Monat_zahl_ermitteln(string eingabe_monat_jahr)
        {
            return eingabe_monat_jahr.Substring(0, eingabe_monat_jahr.Length - 5);
        }

        private static string Monat_name_ermitteln(string monat, string jahr)
        {
            switch (monat)
            {
                case "1":
                    return "     Januar " + jahr;
                case "2":
                    return "    Februar " + jahr;
                case "3":
                    return "      März " + jahr;
                case "4":
                    return "      April " + jahr;
                case "5":
                    return "       Mai " + jahr;
                case "6":
                    return "      Juni " + jahr;
                case "7":
                    return "      Juli " + jahr;
                case "8":
                    return "     August " + jahr;
                case "9":
                    return "   September " + jahr;
                case "10":
                    return "    Oktober " + jahr;
                case "11":
                    return "   November " + jahr;
                case "12":
                    return "   Dezember " + jahr;
                default:
                    return "n.n.";
            }
        }

        private static int Anzahl_Tage_ermitteln(bool schaltjahr, string monat)
        {
            switch (monat)
            {
                case "1":
                    return 31;
                case "2":
                    if (schaltjahr) return 29;
                    else return 28;
                case "3":
                    return 31;
                case "4":
                    return 30;
                case "5":
                    return 31;
                case "6":
                    return 30;
                case "7":
                    return 31;
                case "8":
                    return 31;
                case "9":
                    return 30;
                case "10":
                    return 31;
                case "11":
                    return 30;
                case "12":
                    return 31;
                default:
                    return 0;
            }
        }

        internal static string Erster_Wochentag_ermitteln(string jahr, string monat)
        {
            DateTime tag = new DateTime(Convert.ToInt32(jahr), Convert.ToInt32(monat), 1);
            var wochentag = tag.DayOfWeek;

            return Convert.ToString(wochentag);
        }

        private static string Leerzeichen_schreiben(string erster_wochentag)
        {
            var zeile = "";

            switch (erster_wochentag)
            {
                case "Sunday":
                    return zeile = zeile + " ";
                case "Monday":
                    return zeile = zeile + "    ";
                case "Tuesday":
                    return zeile = zeile + "       ";
                case "Wednesday":
                    return zeile = zeile + "          ";
                case "Thursday":
                    return zeile = zeile + "             ";
                case "Friday":
                    return zeile = zeile + "                ";
                case "Saturday":
                    return zeile = zeile + "                   ";
                default:
                    return zeile = "n.n.";
            }
        }
        private static string Tage_in_Zeile_schreiben(string zeile, int anzahl)
        {
            for (int tag = 1; tag <= anzahl; tag++)
            {
                if (tag < 9)
                zeile = zeile + tag + "  ";
                else zeile = zeile + tag + " ";
            }
            return zeile;        
        }

        internal static List<string> Kalender_formatieren(string monat_name, string zeile)
        {
            var kalender = new List<string>();

            kalender.Add(monat_name);
            kalender.Add("So Mo Di Mi Do Fr Sa ");

            var anzahl_zeilen = zeile.Length / 21;

            if ((zeile.Length % 21) > 0)
            {
                anzahl_zeilen++ ;
            }

            for (int i = 1; i <= anzahl_zeilen; i++)
            {
                if (zeile.Length >=21)
                {
                    kalender.Add(zeile.Substring(0, 21));
                    zeile = zeile.Substring(21);
                }
                else
                {
                    kalender.Add(zeile);
                }
            }
            return kalender;
        }
    }
}
