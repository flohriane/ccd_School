using more;

namespace more_ui_tests
{
    internal class Program
    {
        public static void Main(string[] args) {
            var sut = new PagewisePresentation();
            sut.Display("1\n2\n3\n4\n5\n6\n7", 3);
        }
    }
}