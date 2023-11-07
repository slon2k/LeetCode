using System.Runtime.Serialization.Formatters;

namespace LeetCode.LeetCode75;

public class MaxConsecutiveOnesIII
{
    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            int maxLength = 0;

            var queue = new BinaryQueue();

            foreach (int x in nums)
            {
                queue.Add(x);

                while(!queue.IsEmpty && queue.ZerosCount > k)
                {
                    queue.Remove();
                }

                maxLength = Math.Max(maxLength, queue.Count);
            }

            return maxLength;
        }

        private class BinaryQueue
        {
            private int count = 0;

            private Queue<int> queue = new();

            public void Add(int x)
            {
                queue.Enqueue(x);

                if (x == 0)
                {
                    count++;
                }
            }

            public void Clear()
            {
                queue.Clear();
                count = 0;
            }

            public void Remove()
            {
                int x = queue.Dequeue();

                if (x == 0)
                {
                    count--;
                }
            }

            public int Count => queue.Count;

            public bool IsEmpty => queue.Count == 0;

            public int ZerosCount => count;
        }

    }
}
