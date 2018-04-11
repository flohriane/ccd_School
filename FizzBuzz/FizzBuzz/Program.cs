using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie ein Zahl zwischen 1 und 100 ein: ");
            var obergrenze = Convert.ToInt32(Console.ReadLine());
            Woerterbuch.Uebersetze(obergrenze);
        }

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed !");
        }
    }
}
