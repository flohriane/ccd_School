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
