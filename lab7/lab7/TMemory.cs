namespace lab7
{
    public class TMemory<T> where T : new()
    {
        public T data;
        private bool fState = false;

        public TMemory()
        {
            data = new T();
            fState = false;
        }

        public void WriteMemory(T number)
        {
            data = number;
            fState = true;
        }

        public T Get()
        {
            fState = true;
            return data;
        }

        public void Add(T addComplex)
        {
            data = (dynamic)addComplex + (dynamic)data;
            fState = true;
        }

        public void Clear()
        {
            data = new T();
            fState = false;
        }

        public bool ReadState()
        {
            return fState;
        }

        public T ReadNumber()
        {
            return data;
        }
    }
}