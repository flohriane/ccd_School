using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    public class Monatskalender
    {
        public static List<string> Kalender_erstellen(string[] args) {
            var cli = new CLI(args);
            var anzahl_tage = Kalender.Anzahl_Tage_im_Monat_berechnen(cli.Jahr, cli.Monat);
            var kalender_liste = Formatierer.Formatieren(cli.Monat, cli.Jahr, anzahl_tage);
            return kalender_liste;
        }
    }
}
