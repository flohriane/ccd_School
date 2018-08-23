using System;

namespace stackv3
{
    public class Stapel<T>
    {
        private Eintrag<T> _oberster; // Zeiger !!!

        
        public int Count
        {
            get {
                int n = 0;
                Eintrag<T> eintrag = _oberster;
                while (eintrag != null) {
                    n++;
                    eintrag = eintrag.nächster;
                }
                return n;
            }
        }
        
        
        public void Push(T neu)
        {
            var eintragNeu = new Eintrag<T>(neu); 
            if (_oberster != null)
            {
                eintragNeu.nächster = _oberster;
            }

            _oberster = eintragNeu;
        }

        public Eintrag<T> Peek() // gibt Zeiger auf den obersten Eintrag zurück - nicht den Wert !
        {
            return _oberster;
        }

        public Eintrag<T> Pop()
        {
            if (_oberster != null)
            {
                _oberster = _oberster.nächster;
                return _oberster;
            }
            return null;
        }
    }
}
