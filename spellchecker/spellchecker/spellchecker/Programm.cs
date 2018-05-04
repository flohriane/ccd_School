using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spellchecker
{
    class Programm
    {
        static void Main(string[] args)
        {
            var ui = new UI();
            var fs = new Filesystem();
            var cli = new CLI(args);

#region Wörter aus Quellen holen

            var liste = fs.Wortlistendatei_holen(cli.Dateiname);
            var prüfwörter = cli.Prüfwörter_von_Konsole_holen();
#endregion

            var fehler = Spellchecker_Start.Wörter_auf_Fehler_überprüfen(liste, prüfwörter);

            ui.Fehlerliste_ausgeben(fehler);     
        }       
    }
}
