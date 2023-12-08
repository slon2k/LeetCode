namespace LeetCode.LeetCode150.ArrayString;

public class RemoveDuplicates
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int left = 1, right = 1, length = nums.Length;

            if (length <= 1)
            {
                return length;
            }

            int prev = nums[0];

            while (right < length)
            {
                int current = nums[right++];

                if (current != prev)
                {
                    nums[left++] = current;
                }
                
                prev = current;
            }

            return left;
        }
    }
}
