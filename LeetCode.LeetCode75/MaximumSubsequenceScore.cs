﻿namespace LeetCode.LeetCode75;

public class MaximumSubsequenceScore
{
    public class Solution
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            long result = long.MinValue;

            List<(int num1, int num2, long sum)> numbers = new();

            for (int i = 0; i < nums1.Length; i++)
            {
                numbers.Add((nums1[i], nums2[i], 0));
            }

            numbers.Sort((x, y) => x.num2.CompareTo(y.num2));

            var queue = new PriorityQueue();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                var item = numbers[i];

                numbers[i] = (item.num1, item.num2, queue.Sum + item.num1);

                queue.Enqueue(item.num1);

                if (queue.Count > k - 1)
                {
                    queue.Dequeue();
                }
            }

            for (int i = numbers.Count - k; i >= 0; i--)
            {
                long currentResult = numbers[i].num2 * numbers[i].sum;

                if (currentResult > result)
                {
                    result = currentResult;
                }
            }

            return result;
        }

        private class PriorityQueue
        {
            private PriorityQueue<int, int> queue = new();

            private long sum = 0;

            public int Count => queue.Count;

            public long Sum => sum;

            public void Enqueue(int item)
            {
                sum += item;

                queue.Enqueue(item, item);
            }

            public int Dequeue()
            {
                int item = queue.Dequeue();

                sum -= item;

                return item;
            }
        }
    }
}
