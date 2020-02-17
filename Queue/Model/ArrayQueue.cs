using System.Collections.Generic;
using System.Linq;

namespace Queue.Model
{
    public class ArrayQueue<T>
    {
        private T[] items;

        private T Head => items[Count > 0 ? Count - 1 : 0];
        private T Tail => items[0];
        private int MaxCount => items.Length;

        public int Count { get; private set; }

        public ArrayQueue(int size)
        {
            items = new T[size];
            Count = 0;
        }
        public ArrayQueue(int size, T data)
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count < MaxCount)
            {
                var result = (new T[] { data }).Concat(items);
                items = result.ToArray();
                Count++;
            }
        }

        public T Dequeue()
        {
            var item = Head;
            Count--;
            return item;
        }

        public T Peek()
        {
            return Head;
        }
    }
}
