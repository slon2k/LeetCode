namespace LeetCode.LeetCode150.ArrayString;

public class RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            int left = 0, right = nums.Length - 1;

            while (left < right)
            {
                if (nums[right] == val)
                {
                    right--;
                    continue;
                }

                if (nums[left] != val) 
                {
                    left++;
                    continue;
                }

                (nums[left], nums[right]) = (nums[right], nums[left]);
            }

            if (nums[left] == val)
            {
                return left;
            }

            return left + 1;
        }
    }
}
