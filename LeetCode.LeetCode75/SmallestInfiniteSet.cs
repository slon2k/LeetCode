namespace LeetCode.LeetCode75;

public class SmallestInfiniteSet
{
    private readonly PriorityQueue priorityQueue = new();
    
    private int limit = 0;

    public SmallestInfiniteSet()
    {

    }

    public int PopSmallest()
    {
        if (priorityQueue.Count == 0)
        {
            return ++limit;
        }

        return priorityQueue.Dequeue();
    }

    public void AddBack(int num)
    {
        if (num <= limit)
        {
            priorityQueue.Add(num);
        }
    }

    private class PriorityQueue
    {
        private readonly PriorityQueue<int, int> queue = new();
        private readonly HashSet<int> set = new();

        public int Count => queue.Count;

        public int Dequeue()
        {
            var element = queue.Dequeue();
            set.Remove(element);
            
            return element;
        }

        public void Add(int element)
        {
            if (!set.Contains(element))
            {
                queue.Enqueue(element, element);
                set.Add(element);
            }
        }
    }
}
