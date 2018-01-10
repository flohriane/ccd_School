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
            Assert(d["a"] == "1");
        }

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed!");
        }
    }

    class Converter
    {
        public static IDictionary<string, string> ToDictionary(string input)
        {
            return new Dictionary<string, string>{{"a", "99"}};
        }
    }
}