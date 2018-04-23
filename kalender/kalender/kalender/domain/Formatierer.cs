using System.Collections.Generic;

namespace kalender
{
    static class Formatierer
    {
        public static List<string> Formatieren(int monat_zahl, int jahr, int anzahl_tage) {
            var erster_wochentag = Kalender.Erster_Wochentag_ermitteln(jahr, monat_zahl);
            return Tabellarisch_formatieren(jahr, monat_zahl, anzahl_tage, erster_wochentag);
        }

        private static List<string> Tabellarisch_formatieren(int jahr, int monat, int anzahl_tage, string erster_wochentag) {
            var monat_name = Monat_name_ermitteln(monat);
            var kalender_zeile = Leerzeichen_schreiben(erster_wochentag);
            kalender_zeile = Tage_in_Zeile_schreiben(kalender_zeile, anzahl_tage);
            var kalender_liste = Kalender_formatieren(monat_name, jahr, kalender_zeile);
            return kalender_liste;
        }

        
        private static string Monat_name_ermitteln(int monat) {
            switch (monat) {
                case 1:
                    return "Januar";
                case 2:
                    return "Februar";
                case 3:
                    return "März";
                case 4:
                    return "April";
                case 5:
                    return "Mai";
                case 6:
                    return "Juni";
                case 7:
                    return "Juli";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "Oktober";
                case 11:
                    return "November";
                case 12:
                    return "Dezember";
                default:
                    return "n.n.";
            }
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

        
        internal static List<string> Kalender_formatieren(string monatsname, int jahr, string zeile)
        {
            var kalender = new List<string>();

            var überschrift = $"{monatsname} {jahr}";
            var wochentage = "So Mo Di Mi Do Fr Sa ";
            var padding = (wochentage.Length - überschrift.Length) / 2;
            kalender.Add(überschrift.PadLeft(padding + überschrift.Length));
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