using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Stack
    {
        private int _zaehler = 0;
        private List<int> Eintraege = new List<int>();

        public void Push(int eintrag)
        {
            Eintraege.Add(eintrag);

            _zaehler = _zaehler +1;
        }

        public int Count()
        {
            return _zaehler;
        }

        public int Pop()
        {
            var letzterEintrag = Eintraege.Last();

            Eintraege.RemoveAt(Eintraege.Count-1);

            _zaehler--;

            return letzterEintrag;
        }

        public int Peek(int stapelstelle)
        {

            return Eintraege[stapelstelle];
        }
    }
}
