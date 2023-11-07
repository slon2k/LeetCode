namespace LeetCode.LeetCode75;

public class FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums)
        {
            int sum = 0, left = 0, right = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            right = sum;

            for (int i = 0; i < nums.Length; i++)
            {

                right -= nums[i];

                if (left == right)
                {
                    return i;
                }

                left += nums[i];
            }

            return -1;
        }
    }
}
