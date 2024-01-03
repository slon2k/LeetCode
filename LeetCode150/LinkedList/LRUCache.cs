namespace LeetCode.LeetCode150.LinkedList;

public class LRUCache
{
    private readonly int capacity;

    private int size = 0;

    private ListNode? head = null;

    private ListNode? tail = null;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        var (prev, node) = Find(key);

        if (node is null)
        {
            return -1;
        }

        int value = node.Value;

        RemoveNode(prev, node);

        AddNode(key, value);

        return value;
    }

    private void AddNode(int key, int value)
    {
        ListNode node = new(key, value);

        if (head is null)
        {
            head = node;
            tail = head;
            size = 1;

            return;
        };

        tail.Next = node;
        tail = tail.Next;

        size++;

        if (size > capacity)
        {
            head = head.Next;
            size--;
        }

        return;
    }

    private void RemoveNode(ListNode? prev, ListNode node)
    {
        if (prev is null)
        {
            head = node.Next;

            if (head is null)
            {
                tail = null;
            }

            size--;

            return;
        }

        prev.Next = node.Next;

        size--;

        if (prev.Next is null)
        {
            tail = prev;
        }
    }

    public void Put(int key, int value)
    {
        if (head is null)
        {
            head = new(key, value);
            tail = head;
            size = 1;

            return;
        }

        var (prev, node) = Find(key);

        if (node is not null)
        {
            RemoveNode(prev, node);
        }

        AddNode(key, value);
    }

    private (ListNode? prev, ListNode? node) Find(int key)
    {
        ListNode? prev = null;
        ListNode? node = head;

        while (node is not null)
        {
            if (node.Key.Equals(key))
            {
                return (prev, node);
            }

            prev = node;
            node = node.Next;
        }

        return (null, null);
    }

    private class ListNode
    {
        public ListNode(int key, int value)
        {
            Key = key;
            Value = value;
        }

        public int Key { get; init; }

        public int Value { get; set; }

        public ListNode? Next { get; set; } = null;
    }
}
