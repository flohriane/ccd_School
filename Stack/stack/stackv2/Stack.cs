using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Stack<T>
    {
        private readonly List<T> _einträge = new List<T>();

        public void Push(T eintrag)
        {
            _einträge.Add(eintrag);
        }

        public int Count() {
            return _einträge.Count;
        }

        public T Pop()
        {
            var letzterEintrag = _einträge.Last();
            _einträge.RemoveAt(_einträge.Count-1);
            return letzterEintrag;
        }

        public T Peek() {
            return _einträge.Last();
        }
    }
}
