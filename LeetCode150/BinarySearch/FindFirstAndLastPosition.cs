namespace LeetCode.LeetCode150.BinarySearch;

internal class FindFirstAndLastPosition
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return [-1, -1];
            }

            int left = 0;
            int right = nums.Length - 1;

            if (nums[left] > target || nums[right] < target)
            {
                return [-1, -1];
            }

            if (nums[left] == target)
            {
                return [0, FindRight(nums, target, 0, right)];
            }

            if (nums[right] == target)
            {
                return [FindLeft(nums, target, 0, right), right];
            }

            while (left < right - 1) 
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    return [FindLeft(nums, target, left, middle), FindRight(nums, target, middle, right)];
                }

                if (nums[middle] < target)
                {
                    left = middle;
                }
                else
                {
                    right = middle;
                }
            }

            return [-1, -1];
        }

        private int FindLeft(int[] nums, int target, int left, int right)
        {
            if (nums[left] == target)
            {
                return left;
            }

            while (left < right - 1)
            {
                int middle = left + (right - left) / 2;

                if (nums[middle] == target)
                {
                    right = middle;
                } else
                {
                    left = middle;
                }
            }

            return right;
        }

        private int FindRight(int[] nums, int target, int left, int right)
        {
            if (nums[right] == target)
            {
                return right;
            }

            while (left < right - 1)
            {
                int middle = left + (right - left) / 2;
                
                if (nums[middle] == target)
                {
                    left = middle;
                } else
                {
                    right = middle;
                }
            }

            return left;
        }
    }
}
