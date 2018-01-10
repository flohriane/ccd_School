using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace todictionary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var d = Converter.ToDictionary("a=1");     
            Debug.Assert(d["a"] == "1");
        }
    }

    class Converter
    {
        public static IDictionary<string, string> ToDictionary(string input)
        {
            return null;
        }
    }
}