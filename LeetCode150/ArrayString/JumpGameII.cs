namespace LeetCode.LeetCode150.ArrayString;

public class JumpGameII
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            int length = nums.Length;

            int[] jumps = new int[length];

            for (int i = 1; i < length; i++)
            {
                jumps[i] = int.MaxValue;
            }

            for (int i = 0; i < length; i++)
            {                
                if (jumps[i] < int.MaxValue)
                {
                    for (int j = Math.Min(length - 1, i + nums[i]); j > i; j--)
                    {
                        jumps[j] = Math.Min(jumps[j], jumps[i] + 1);
                    }
                }
            }

            return jumps[length - 1];
        }
    }
}