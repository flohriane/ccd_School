using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Stack
    {
        private readonly List<int> _einträge = new List<int>();

        public void Push(int eintrag) {
            _einträge.Add(eintrag);
        }

        public int Count() {
            return _einträge.Count;
        }

        public int Pop()
        {
            var letzterEintrag = _einträge.Last();
            _einträge.RemoveAt(_einträge.Count-1);
            return letzterEintrag;
        }

        public int Peek() {
            return _einträge.Last();
        }
    }
}
