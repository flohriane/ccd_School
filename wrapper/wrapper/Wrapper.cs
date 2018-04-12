using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wrapper
{
    public class Wrapper
    {
        public string Wrap(string text, int maxLineLength)
        {
            var words = Split_into_words(text);
            return Create_lines_from_words(words, maxLineLength);
        }

        private string[] Split_into_words(string text)
        {
            throw new NotImplementedException();
        }
        private string Create_lines_from_words(string[] words, int maxLineLength)
        {
            throw new NotImplementedException();
        }
    }
}
