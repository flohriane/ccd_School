using System.IO;

namespace more
{
    class Filesystem
    {
        public string Load_text(string filename) {
            return File.ReadAllText(filename);
        }
    }
}