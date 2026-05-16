namespace LeetCode2026.BinarySearch;

// 153. Find Minimum in Rotated Sorted Array
// Suppose an array of length n sorted in ascending order is rotated between 1 and n times
// For example, the array nums = [0,1,2,4,5,6,7] might become:
// [4,5,6,7,0,1,2] if it was rotated 4 times.
// [0,1,2,4,5,6,7] if it was rotated 7 times.
// Given the sorted rotated array nums that may contain duplicates, return the minimum element of this array.
// You must write an algorithm that runs in O(log n) time.

public class FindMinimumInRotatedSortedArrayII
{
    public int FindMin(int[] nums)
    {
        return Search(nums, 0, nums.Length - 1);
    }

    private int Search(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return nums[left];
        }

        var mid = left + (right - left) / 2;

        if (nums[mid] > nums[right])
        {
            return Search(nums, mid + 1, right);
        }
        else if (nums[mid] < nums[right])
        {
            return Search(nums, left, mid);
        }
        else
        {
            return Search(nums, left, right - 1);
        }
    }
}