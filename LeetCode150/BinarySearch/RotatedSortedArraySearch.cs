
namespace LeetCode.LeetCode150.BinarySearch;

internal class RotatedSortedArraySearch
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            return Find(target, nums, 0, nums.Length - 1);
        }

        private int Find(int target, int[] nums, int left, int right)
        {
            if (nums[left] == target)
            {
                return left;
            }

            if (nums[right] == target)
            {
                return right;
            }

            if (left >= right - 1)
            {
                return -1;
            }

            int middle = left + (right - left) / 2;

            if (nums[middle] == target)
            {
                return middle;
            }

            if (nums[middle] > nums[left])
            {
                if (nums[middle] > target && nums[left] < target)
                {
                    return Find(target, nums, left, middle);
                }
                else
                {
                    return Find(target, nums, middle, right);
                }
            }

            if (nums[middle] < nums[right])
            {
                if (nums[middle] < target && nums[right] > target)
                {
                    return Find(target, nums, middle, right);
                }
                else
                {
                    return Find(target, nums, left, middle);                    
                }
            }

            if (nums[left] < target || nums[right] > target)
            {
                return Find(target, nums, left, middle);
            }
            else
            {
                return Find(target, nums, middle, right);
            }
        }
    }
}