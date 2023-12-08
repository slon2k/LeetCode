namespace LeetCode.LeetCode150.ArrayString;

public class RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;

            k %= length;

            int[] buffer = new int[k];

            for (int i = 0; i < k; i++)
            {
                buffer[i] = nums[length - k + i];
            }

            for (int i = length - 1; i - k >= 0; i--)
            {
                nums[i] = nums[i - k];
            }

            for (int i = 0; i < k; i++)
            {
                nums[i] = buffer[i];
            }
        }
    }
}
