namespace LeetCode.LeetCode75;

public class FindPeakElement
{
    public class Solution
    {
        public int FindPeakElement(int[] nums)
        {
            int left = 0;

            int right = nums.Length - 1;
            
            while (left + 1 < right)
            {
                int middle = left + (right - left)/2;

                if (nums[middle] < nums[middle - 1])
                {
                    right = middle;
                } else
                {
                    left = middle;
                }    
            }

            return nums[right] > nums[left] ? right : left;
        }
    }
}
