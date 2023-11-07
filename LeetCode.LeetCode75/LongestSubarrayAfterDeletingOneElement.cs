namespace LeetCode.LeetCode75;

public class LongestSubarrayAfterDeletingOneElement
{
    public class Solution
    {
        public int LongestSubarray(int[] nums)
        {
            int maxLength = 0;

            var queue = new BinaryQueue();

            foreach (var item in nums)
            {
                queue.Add(item);

                while (queue.GetZeroCount() > 1)
                {
                    queue.Remove();
                }

                int length = queue.GetLength() - 1;

                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            return maxLength;
        }

        private class BinaryQueue
        {
            private Queue<int> queue = new Queue<int>();

            private int count = 0;

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

            public int GetZeroCount() => count;

            public int GetLength() => queue.Count;
        }
    }
}
