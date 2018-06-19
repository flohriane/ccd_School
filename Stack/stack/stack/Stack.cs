using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class Stack
    {
        private int zaehler = 0;
        private List<int> Einträge = new List<int>();

        public void push(int eintrag)
        {
            Einträge.Add(eintrag);

            zaehler = zaehler + 1;
        }

        public int count()
        {
            return zaehler;
        }

        public int pop()
        {
            int letzterEintrag = Einträge.Last();

            Einträge.RemoveAt(Einträge.Count-1);

            return letzterEintrag;
        }
    }
}
