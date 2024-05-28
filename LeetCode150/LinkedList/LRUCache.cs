namespace LeetCode.LeetCode150.LinkedList;

public class LRUCache(int capacity) : LRUCache<int, int>(capacity, -1);

public class LRUCache<TKey, TValue> where TKey : notnull
{
    private readonly int capacity;

    private readonly TValue defaultValue;

    private readonly LinkedList<TKey> list = []; 

    private readonly Dictionary<TKey, Item> values = [];

    protected LRUCache(int capacity, TValue defaultValue)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(capacity);

        this.capacity = capacity;
        this.defaultValue = defaultValue;
    }

    public TValue Get(TKey key)
    {
        if (values.TryGetValue(key, out var item))
        {
            if (item is null)
            {
                values.Remove(key);
                return defaultValue;
            }

            Access(item.Node);

            return item.Value;
        }

        return defaultValue;
    }

    public void Put(TKey key, TValue value)
    {
        if (values.TryGetValue(key, out var item))
        {
            item.Value = value;
            Access(item.Node);
            return;
        }

        if (values.Count == capacity)
        {
            var last = list.Last;
            
            if (last is not null)
            {
                values.Remove(last.Value);
                list.Remove(last);
            }
        }

        var node = list.AddFirst(key);

        values.Add(key, new Item(value, node));
    }

    private void Access(LinkedListNode<TKey> node) 
    {
        list.Remove(node);
        list.AddFirst(node);
    }

    private class Item (TValue value, LinkedListNode<TKey> node)
    {
        public TValue Value { get; set; } = value;

        public LinkedListNode<TKey> Node { get; set; } = node;
    };
}
