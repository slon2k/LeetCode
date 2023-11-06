using System.Runtime.Serialization.Formatters;

namespace LeetCode.LeetCode75;

public class MaximumAverageSubarrayI
{
    public class Solution
    {
        public double FindMaxAverage(int[] numbers, int k)
        {
            long sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += numbers[i];
            }

            long max = sum;

            for (int i = k; i < numbers.Length; i++)
            {
                sum -= numbers[i - k];
                sum += numbers[i];

                if (sum > max)
                {
                    max = sum;
                }
            }

            return (double) max / k;
        }
    }
}
