namespace Queue.Model
{
    public class DuplexLinkedDeque<T>
    {
        private DuplexItem<T> _head;
        private DuplexItem<T> _tail;
        public int Count { get; private set; }

        public DuplexLinkedDeque() { }
        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new DuplexItem<T>(data);
            _head = item;
            _tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Next = _tail;
            _tail.Previous = item;
            _tail = item;
            Count++;
        }

        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new DuplexItem<T>(data);
            item.Previous = _head;
            _head.Next = item;
            _head = item;
            Count++;
        }

        public T PopBack()
        {
            if (Count > 0)
            {
                var result = _tail.Data;
                var current = _tail.Next;
                current.Previous = null;
                _tail = current;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public T PopFront()
        {
            if (Count > 0)
            {
                var result = _head.Data;
                var current = _head.Previous;
                current.Next = null;
                _head = current;
                Count--;
                return result;
            }
            else
            {
                return default(T);
            }
        }

        public T PeekBack()
        {
            return _tail.Data;
        }

        public T PeekFront()
        {
            return _head.Data;
        }
    }
}
