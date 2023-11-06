using System.Collections.Immutable;

namespace LeetCode.LeetCode75;

public class MaxNumberKSumPairs
{
    public class Solution
    {
        public int MaxOperations(int[] numbers, int k)
        {
            int count = 0;

            Array.Sort(numbers);

            int left = 0, right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] == k)
                {
                    count++;
                    left++;
                    right--;

                    continue;
                }

                if (numbers[left] + numbers[right] < k)
                {
                    left++;

                    continue;
                }

                right--;
            }

            return count;
        }
    }
}
