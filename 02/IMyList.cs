namespace _02
{


    public interface IMyList<T>
    {
        void Add(T item);

        T this[int i]
        {
            get;
        }

        int Count
        {
            get;
        }

    }
}

