namespace LeetCode.LeetCode150.DP;

public class LongestIncreasingSubsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int[] result = Enumerable.Repeat(1, nums.Length).ToArray();

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++) 
                {
                    if (nums[i] > nums[j])
                    {
                        result[i] = Math.Max(result[i], result[j] + 1);
                    }
                }
            }

            return result.Max();
        }
    }
}
