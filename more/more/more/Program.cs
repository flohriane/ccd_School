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
            var fs = new Filesystem();
            var presenter = new PagewisePresentation();
            
            var text = fs.Load_text(cli.Filename);
            presenter.Display(text, cli.PageLen);
        }
    }
}
