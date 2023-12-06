namespace LeetCode.LeetCode75;

public class HireWorkersTotalCost
{
    public class Solution
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            long result = 0;

            PriorityQueue<int, int> queue1 = new();
            PriorityQueue<int, int> queue2 = new();

            List<int> list = new(costs);

            for (int i = 0; i < candidates; i++)
            {
                if (list.Count > 0)
                {
                    int item = list.First();
                    queue1.Enqueue(item, item);

                    list.RemoveAt(0);
                }

                if (list.Count > 0)
                {
                    int item = list.Last();
                    queue2.Enqueue(item, item);

                    list.RemoveAt(list.Count - 1);
                }
            }

            while (k > 0)
            {
                int item1 = queue1.Count > 0 ? queue1.Peek() : int.MaxValue;
                int item2 = queue2.Count > 0 ? queue2.Peek() : int.MaxValue;

                if (item1 <= item2)
                {
                    result += queue1.Dequeue();

                    if (list.Count > 0)
                    {
                        int item = list.First();
                        queue1.Enqueue(item, item);

                        list.RemoveAt(0);
                    }
                } else
                {
                    result += queue2.Dequeue();

                    if (list.Count > 0)
                    {
                        int item = list.Last();
                        queue2.Enqueue(item, item);

                        list.RemoveAt(list.Count - 1);
                    }
                }

                k--;
            }
        
            return result;
        }
    }
}
