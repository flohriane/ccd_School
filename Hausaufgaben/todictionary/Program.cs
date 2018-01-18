using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace todictionary
{
    class Converter2
    {
        // Integration
        public static Dictionary<string, string> ToDict(string configuration) 
        {
            // "a=1;b=2" -> ["a=1", "b=2"]
            string[] zuweisungen = Program.Ich_erkenne_Semikolons(configuration);
            
            // ["a=1", "b=2"] -> [ ["a", "1"], ["b", "2"] ]
            List<string[]> paare = Program.Ich_erkenne_Gleichheitszeichen(zuweisungen);
            
            // [ ["a", "1"], ["b", "2"] ] -> { {"a","1"}, {"b","2"} }
            Dictionary<string,string> dict = Program.Ich_baue_ein_Dictionary(paare);
            return dict;
        }
    }

    internal class Program
    {
        public static void Main()
        {
            var configuration = "a=1;b=2;c=3";  // Beispiel

            var d = Converter2.ToDict(configuration);
            Assert(d["a"] == "1");
        }

        // Operation
        public static string[] Ich_erkenne_Semikolons(string configuration)
        {
            string[] zuweisungen = configuration.Split(';');

            return zuweisungen;
        }

        // Operation
        public static List<string[]> Ich_erkenne_Gleichheitszeichen(string[] zuweisungen)
        {
            List<string[]> paare = new List<string[]>();

            for (int i = 0; i < (zuweisungen.Length); i++)
            {
                paare.Add(zuweisungen[i].Split('='));
            }

            return paare;
        }

        // Operation
        public static Dictionary<string, string> Ich_baue_ein_Dictionary(List<string[]> paare)
        {
            Dictionary<string, string> DicEinzelwerte = new Dictionary<string, string>();

            foreach (string[] paar in paare)
            {
                for (int i = 1; i < (paar.Length); i++)
                {
                    DicEinzelwerte.Add($"{paar[i - 1]}", $"{paar[i]}");
                }
            }

            return DicEinzelwerte;
        }

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed!");
        }
    }
}