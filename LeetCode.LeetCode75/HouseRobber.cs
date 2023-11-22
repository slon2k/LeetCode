namespace LeetCode.LeetCode75;

public class HouseRobber
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            int length = nums.Length;

            if (length == 1)
            {
                return nums[0];
            }

            int[] max = new int[length];

            max[0] = nums[0];

            max[1] = Math.Max(max[0], nums[1]);

            for (int i = 2; i < length; i++)
            {
                max[i] = Math.Max(max[i - 2] + nums[i], max[i - 1]);
            }

            return max[length - 1];
        }
    }
}
