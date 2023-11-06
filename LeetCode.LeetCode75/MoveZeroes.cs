namespace LeetCode.LeetCode75;

public class MoveZeroes
{
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int count = 0;
            
            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                    continue;
                }

                if (count > 0)
                {
                    nums[i - count] = nums[i];
                }
            }

            for (int i = 0; i < count; i++)
            {
                nums[length - 1 - i] = 0;
            }
        }
    }
}
