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
            
            var text = fs.Eingabetext_holen(cli.dateiname);
            var zu_prüfende_wörter = Spellchecker_Start.Text_in_Wörter_zerlegen(text);
            var referenzwörter = fs.Wortliste_holen(@"C: \Users\FlohrCh\Documents\Source\Repos\ccd_School\spellchecker\wortliste.txt");

            var fehler = Spellchecker_Start.Wörter_auf_Fehler_überprüfen(referenzwörter, zu_prüfende_wörter);

            ui.Fehlerliste_ausgeben(fehler);     
        }       
    }
}
