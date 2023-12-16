namespace LeetCode.LeetCode150.SlidingWindow;

public class MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue;
            int length = nums.Length;

            int left = 0;
            int right = 0;

            long sum = nums[0];

            while (left < length && right < length)
            {
                if (sum < target)
                {
                    right++;

                    if (right == length)
                    {
                        break;
                    }

                    sum += nums[right];
                }

                if (sum >= target)
                {
                    int current = right - left + 1;
                    
                    if (current < minLength)
                    {
                        minLength = current;
                    }

                    sum -= nums[left];
                    left++;
                }
            }

            return minLength < int.MaxValue ? minLength : 0;
        }
    }
}
