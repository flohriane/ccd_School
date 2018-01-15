using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace todictionary
{
    internal class Program
    {
        public static void Main(string[] args)
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

            // fussgesteuerte Schleife, um String zu zerteilen und leeren String zuzulassen
            do
            {
                int semicolonPosition = example.IndexOf(semicolon);    // zeigt Stelle an, an der das Semicolon auftaucht
                if (semicolonPosition > 0)
                {
                        putToDic = example.Substring(0, semicolonPosition); // enthält 1 Wertepaar für Dictionary 
                        Converter.ToDictionary(putToDic);
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

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed!");
        }
        // ???
    }

    class Converter
    {
        public static IDictionary<string, string> ToDictionary(string input)
        {
            string a = "";
            string b = "";

            if (input != "")
            {
                a = input.Substring(0, 1);
                b = input.Substring(2);

                // dient Test
                Console.WriteLine("Inhalt Dic "+a+"   "+b);
            }
            return new Dictionary<string, string>{{a, b}};
        }
    }
}