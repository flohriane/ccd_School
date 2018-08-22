using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackv3
{
    public class Eintrag<T>
    {
        public T wert;
        public Eintrag<T> nächster;

        public Eintrag(T i)
        {
            wert = i;
        }
    }
}
