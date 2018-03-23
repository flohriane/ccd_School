using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more
{
    //            args[0]        args[1]
    // $ more.exe meinedatei.txt 15
    class Program
    {
        static void Main(string[] args)
        {
            var cli = new Cli(args);
            var ui = new UI();
            var fs = new Filesystem();
            
            var text = fs.Load_text(cli.Filename);
            var seiten = Pagination.Convert(text, cli.PageLen);
            ui.Ausgeben(seiten);
        }
    }
}
