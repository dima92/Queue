namespace Queue.Model
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
