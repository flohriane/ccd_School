using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackv3
{
    public class Stapel<T>
    {
        internal int _zaehler = 0;
        internal Eintrag<T> _oberster;
        internal void Push(T neu)
        {
            var eintragNeu = new Eintrag<T>(neu); 
            if (_oberster != null)
            {
                eintragNeu.nächster = _oberster;
            }

            _oberster = eintragNeu;
            _zaehler++;
        }

        internal Eintrag<T> Peek() // gibt Zeiger auf den obersten Eintrags zurück
        {
            return _oberster;
        }
    }
}
