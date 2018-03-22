using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more
{
    class Program
    {
        static void Main(string[] args)
        {
            More more = new More();
            More_Lambda more_lambda = new More_Lambda();

            //more.Textausgabe_formatieren();           // Variante I
            more_lambda.Textausgabe_formatieren();    // Variante II
        }
    }
}
