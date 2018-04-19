using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    class CLI
    {
        private readonly string[] _args;
        public CLI(string[] args)
        {
            _args = args;
        }
        public string Filename => _args[0];
    }
}
