using System;

namespace stackv3
{
    public class Stapel<T>
    {
        private class Eintrag<T>
        {
            public T wert;
            public Eintrag<T> nächster;

            public Eintrag(T i)
            {
                wert = i;
            }
        }
        
        
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
        
        
        public void Push(T neu) {
            var eintragNeu = new Eintrag<T>(neu); 
            if (_oberster != null)
                eintragNeu.nächster = _oberster;
            _oberster = eintragNeu;
        }

        public T Peek() // gibt Zeiger auf den obersten Eintrag zurück - nicht den Wert !
            => _oberster.wert;

        public T Pop()
        {
            if (_oberster == null) throw new InvalidOperationException("Stack empty!");

            var top = _oberster.wert;
            _oberster = _oberster.nächster;
            return top;
        }
    }
}
