using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackv3
{
    public class Stapel<T>
    {
        internal int zaehler = 0;
        private Eintrag<T> _oberster;
        public void Push(T neu)
        {
            var eintragNeu = new Eintrag<T>(neu); 
            if (_oberster != null)
            {
                eintragNeu.nächster = _oberster;
            }

            _oberster = eintragNeu;
            zaehler++;
        }
    }
}
