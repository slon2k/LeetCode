namespace LeetCode.LeetCode150.BinarySearch;

public class SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int left = 0;
            int right = nums.Length - 1;

            if (target <= nums[left]) 
            {
                return left;
            }

            if (target > nums[right]) 
            {
                return right + 1;
            }

            if (target == nums[right])
            {
                return right;
            }

            while (left < right - 1)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    return middle;
                }

                if (nums[middle] > target)
                {
                    right = middle;
                } else
                {
                    left = middle;
                }
            }

            return right;
        }
    }
}
