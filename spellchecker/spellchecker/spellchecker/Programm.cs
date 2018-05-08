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

#region Wörter aus Dateien holen

            var prüfwörter = fs.Datei_holen(cli.dateiname);
            var wörter = fs.Datei_holen(@"C: \Users\FlohrCh\Documents\Source\Repos\ccd_School\spellchecker\wortliste.txt");
#endregion

            var fehler = Spellchecker_Start.Wörter_auf_Fehler_überprüfen(wörter, prüfwörter);

            ui.Fehlerliste_ausgeben(fehler);     
        }       
    }
}
