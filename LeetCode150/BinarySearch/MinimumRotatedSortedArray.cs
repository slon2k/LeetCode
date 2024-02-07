namespace LeetCode.LeetCode150.BinarySearch;

internal class MinimumRotatedSortedArray
{
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            return FindMin(nums, 0, nums.Length - 1);
        }

        private int FindMin(int[] nums, int left, int right)
        {
            if (left == right || nums[left] < nums[right])
            {
                return nums[left];
            }

            if (left == right - 1)
            {
                return Math.Min(nums[left], nums[right]);
            }

            int middle = left + (right - left) / 2;

            if (nums[left] >= nums[middle] && nums[middle] >= nums[right]) 
            {
                return FindMin(nums, middle, right);
            }

            return Math.Min(FindMin(nums, left, middle), FindMin(nums, middle, right));
        }
    }
}
