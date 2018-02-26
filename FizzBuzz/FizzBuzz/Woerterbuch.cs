using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class Woerterbuch
    {
        public static void Uebersetze(int obergrenze)
        {
            var woerterbuchFizzBuzz = Nach_FizBuzz_übersetzen(obergrenze);
            Gib_Übersetzung_aus(woerterbuchFizzBuzz, obergrenze);
        }

        internal static Dictionary<int, string> Nach_FizBuzz_übersetzen(int obergrenze)
        {
            Dictionary<int, string> woerterbuchFizzBuzz = ErstelleWoerterbuch(obergrenze);
            UebersetzeWoerterbuch(woerterbuchFizzBuzz, obergrenze);
            return woerterbuchFizzBuzz;
        }
        
        static Dictionary<int, string> UebersetzeWoerterbuch(Dictionary<int, string> woerterbuchFizzBuzz, int obergrenze)
        {
            woerterbuchFizzBuzz = UebersetzeInFizz(woerterbuchFizzBuzz, obergrenze);

            woerterbuchFizzBuzz = UebersetzeInBuzz(woerterbuchFizzBuzz, obergrenze);

            woerterbuchFizzBuzz = UebersetzeInFizzBuzz(woerterbuchFizzBuzz, obergrenze);

            return woerterbuchFizzBuzz;
        }

        static Dictionary<int, string> ErstelleWoerterbuch(int obergrenze)
        {
            Dictionary<int, string> woerterbuchFizzBuzz = new Dictionary<int, string>();

            for (int i = 1; i <= obergrenze; i++)
            {
                woerterbuchFizzBuzz[i] = Convert.ToString(i);
            }

            return woerterbuchFizzBuzz;
        }

        static Dictionary<int, string> UebersetzeInFizz(Dictionary<int, string> woerterbuchFizzBuzz, int obergrenze)
        {
            for (int i = 1; i <= obergrenze; i++)
            {
                if (i % 3 == 0)
                {
                    woerterbuchFizzBuzz[i] = "Fizz";
                }
            }

            return woerterbuchFizzBuzz;
        }

        static Dictionary<int, string> UebersetzeInBuzz(Dictionary<int, string> woerterbuchFizzBuzz, int obergrenze)
        {
            for (int i = 1; i <= obergrenze; i++)
            {
                if (i % 5 == 0)
                {
                    woerterbuchFizzBuzz[i] = "Buzz";
                }
            }

            return woerterbuchFizzBuzz;
        }

        static Dictionary<int, string> UebersetzeInFizzBuzz(Dictionary<int, string> woerterbuchFizzBuzz, int obergrenze)
        {
            for (int i = 1; i <= obergrenze; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    woerterbuchFizzBuzz[i] = "FizzBuzz";
                }
            }

            return woerterbuchFizzBuzz;
        }

        static void Gib_Übersetzung_aus(Dictionary<int, string> woerterbuchFizzBuzz, int obergrenze)
        {
            for (int i = 1; i <= obergrenze; i++)
            {
                Console.WriteLine(woerterbuchFizzBuzz[i]);
            }
        }
    }
}