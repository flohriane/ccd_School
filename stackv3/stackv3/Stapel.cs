namespace stackv3
{
    public class Stapel<T>
    {
        internal int _zaehler = 0;
        internal Eintrag<T> _oberster; // Zeiger !!!
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

        internal Eintrag<T> Peek() // gibt Zeiger auf den obersten Eintrag zurück - nicht den Wert !
        {
            return _oberster;
        }

        internal Eintrag<T> Pop()
        {
            if (_oberster != null)
            {
                _oberster = _oberster.nächster;
                _zaehler--;
                return _oberster;
            }
            return null;
        }
    }
}
