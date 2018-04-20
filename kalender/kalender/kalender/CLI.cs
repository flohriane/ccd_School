using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    class CLI
    // ToDo hier komme ich nicht weiter: 
    // Wie rufe ich das Programm außerhalb von VS auf?
    // Was steht genau in args drin?
    {
        private readonly string[] _args;        
        public CLI(string[] args)
        {
            _args = args;
        }
        public string Filename => _args[0];
    }
}
