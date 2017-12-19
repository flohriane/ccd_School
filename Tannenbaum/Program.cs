using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            View view = new View(model);
            Tannenbaum tannenbaum = new Tannenbaum(model, view);

            tannenbaum.GetStarted();
        }
    }
}
