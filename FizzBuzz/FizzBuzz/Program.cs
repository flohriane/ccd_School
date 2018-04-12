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
            var obergrenze = Benutzereingabe_holen();
            Woerterbuch.Uebersetze(obergrenze);
        }

        static int Benutzereingabe_holen()
        {
            Console.Write("Bitte geben Sie ein Zahl zwischen 1 und 100 ein: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Assert(bool condition)
        {
            if (!condition) throw new InvalidOperationException("Assertion failed !");
        }
    }
}
