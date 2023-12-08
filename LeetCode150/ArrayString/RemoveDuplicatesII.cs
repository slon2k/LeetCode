namespace LeetCode.LeetCode150.ArrayString;

public class RemoveDuplicatesII
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int left = 1, right = 1, length = nums.Length, count = 1;

            if (length <= 1)
            {
                return length;
            }

            int prev = nums[0];

            while (right < length)
            {
                int current = nums[right++];

                if (current == prev)
                {
                    count++;
                } else
                {
                    count = 1;
                }

                if (current != prev || count < 3)
                {
                    nums[left++] = current;
                }
                
                prev = current;
            }

            return left;
        }
    }
}
