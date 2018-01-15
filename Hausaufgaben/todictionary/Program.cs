using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace todictionary
{
    class Converter2
    {
        // Integration
        public static Dictionary<string, string> ToDict(string configuration)
        {
            // "a=1;b=2" -> ["a=1", "b=2"]
            string[] zuweisungen = Ich_erkenne_Semikolons(configuration);
            
            // ["a=1", "b=2"] -> [ ["a", "1"], ["b", "2"] ]
            string[][] paare = Ich_erkenne_Gleichheitszeichen(zuweisungen);
            
            // [ ["a", "1"], ["b", "2"] ] -> { {"a","1"}, {"b","2"} }
            Dictionary<string,string> dict = Ich_baue_ein_Dictionary(paare);
            return dict;
        }
    }
    
    
    internal class Program
    {
        public static void Main()
        {
            var configuration = "x=12;abc=hello";
            var d = Converter2.ToDict(configuration);
            Assert(d["abc"]=="hello");
        }
        
        
        
        public static void Main4()
        {
            var dict = new Dictionary<string,string>();
            var input = "a=1;b=2;c=3";
            Dict_erweitern(input, 3, dict);
            Assert(dict["a"]=="1");
        }
        
        public static void Main3()
        {
            var result = Add(1, 2);
            Assert(result == 3);

            result = Add(-40, -2);
            Assert(result == -42);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static void Main2(string[] args)
        {
            string example = "a=1;b=2;c=3";
            //string example = "a=1;a=2";
            //string example = "a=1;;b=2";        // TODO funktioniert nicht
            //string example = "a=";
            //string example = "=1";              // TODO nicht behandelt
            //string example = "a==1";
            //string example = "";

            string putToDic = "";
            int lengthExample = example.Length;
            Char semicolon = ';';

            var dict = new Dictionary<string,string>();
            // fussgesteuerte Schleife, um String zu zerteilen und leeren String zuzulassen
            do
            {
                int semicolonPosition = example.IndexOf(semicolon);    // zeigt Stelle an, an der das Semicolon auftaucht
                if (semicolonPosition > 0)
                {
                        Dict_erweitern(example, semicolonPosition, dict);

                        //Converter.ToDictionary(putToDic);
                    
                        example = example.Substring(semicolonPosition + 1); // Rest vom String
                        lengthExample = example.Length; // neue Länge 
                }
                else
                {
                    putToDic = example;
                    lengthExample = 0;
                }
            }
            while (lengthExample > 0);

            // ???
            var d = Converter.ToDictionary(putToDic);
            Assert(d["a"] == "1");
        }

        // Operation
        private static void Dict_erweitern(string example, int semicolonPosition, Dictionary<string, string> dict)
        {
            var nameWertPaar = example.Substring(0, semicolonPosition); // enthält 1 Wertepaar für Dictionary 
            
            var name = nameWertPaar.Substring(0, 1); // logik: transformation
            var wert = nameWertPaar.Substring(2);
            
            dict.Add(name, wert);
        }

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed!");
        }
        // ???
    }

    class Converter
    {
        public static IDictionary<string, string> ToDictionary(string nameWertPaar)
        {
            string name = "";
            string wert = "";

            if (nameWertPaar != "") // logik: kontrollstruktur
            {
                name = nameWertPaar.Substring(0, 1); // logik: transformation
                wert = nameWertPaar.Substring(2);

                // dient Test
                Console.WriteLine("Inhalt Dic "+name+"   "+wert); // logik: I/O, seiteneffekt
            }
            else
            {
                Console.WriteLine("...");
            }
            return new Dictionary<string, string>{{name, wert}};
        }
    }
}