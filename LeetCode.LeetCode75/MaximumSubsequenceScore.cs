namespace LeetCode.LeetCode75;

public class MaximumSubsequenceScore
{
    public class Solution
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            long result = long.MinValue;

            for (int i = 0; i < nums2.Length; i++)
            {
                int min = nums2[i];

                PriorityQueue<int, int> priorityQueue = new();

                for (int j = 0; j < nums1.Length; j++)
                {
                    if (i == j || nums2[j] < min)
                    {
                        continue;
                    }

                    priorityQueue.Enqueue(nums1[j], nums1[j]);

                    if (priorityQueue.Count > k - 1)
                    {
                        priorityQueue.Dequeue();
                    }
                }

                if (priorityQueue.Count == k - 1)
                {
                    long sum = nums1[i];

                    while(priorityQueue.Count > 0)
                    {
                        sum += priorityQueue.Dequeue();
                    }

                    if(sum * min > result)
                    {
                        result = sum * min;
                    }
                }
            }

            return result;
        }
    }
}
