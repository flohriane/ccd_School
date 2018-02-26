using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args) {
            Woerterbuch.Uebersetze(31);
        }

        static void Assert(bool condition) {
            if (!condition) throw new InvalidOperationException("Assertion failed !");
        }
    }
}

