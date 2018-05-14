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
            var wörter = Spellchecker.Text_in_Wörter_zerlegen(text);
            var lexikon = fs.Wortliste_holen(@"wortliste.txt");

            var fehler = Spellchecker.Wörter_auf_Fehler_überprüfen(wörter, lexikon);

            ui.Fehlerliste_ausgeben(fehler);     
        }       
    }
}
