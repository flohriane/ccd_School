using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalender
{
    // Wie rufe ich das Programm außerhalb von VS auf? - einfach Dateiname eingeben: $ kalender.exe 2 2018
    // Was steht genau in args drin? - jeder Kommandozeilenparam ist ein Element im Array; der erste Param steht bei args[0]
    class CLI
    {
        private readonly string[] _args;        
        public CLI(string[] args) { _args = args; }
        
        public int Monat => int.Parse(_args[0]);
        public int Jahr => int.Parse(_args[1]);
    }
}
