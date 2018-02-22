using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        class Woerterbuch
        {
            public static Dictionary<int, string> Uebersetze(int obergrenze)
            {
                Dictionary<int, string> woerterbuchFizzBuzz = ErstelleWoerterbuch(obergrenze);

                UebersetzeWoerterbuch(woerterbuchFizzBuzz, obergrenze);

                GibUebersetzungAus(woerterbuchFizzBuzz, obergrenze);

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

            static void GibUebersetzungAus(Dictionary<int, string> woerterbuchFizzBuzz, int obergrenze)
            {
                for (int i = 1; i <= obergrenze; i++)
                {
                    Console.WriteLine(woerterbuchFizzBuzz[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            var obergrenze = 31;

            var woerterbuch = Woerterbuch.Uebersetze(obergrenze);

            Assert(woerterbuch[3] == "Fizz");
            Assert(woerterbuch[5] == "Buzz");
            Assert(woerterbuch[15] == "FizzBuzz");
        }

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed !");
        }
    }
}

