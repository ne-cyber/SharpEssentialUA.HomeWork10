using System;

namespace _02
{

    public class MyList<T> : IMyList<T>
    {

        private T[] items;

        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            Array.Resize(ref items, items.Length + 1);
            items[items.Length - 1] = item;
        }
        public T this[int i]
        {
            get
            {
                if (i < items.Length)
                    return items[i];
                else
                {
                    Console.WriteLine("Індекс виходить за межі границі масиву");
                    return default(T);
                }
            }
        }
        public int Count
        {
            get
            {
                return items.Length;
            }
        }
    }

}
