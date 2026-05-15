namespace LeetCode2026.BinarySearch;

// 153. Find Minimum in Rotated Sorted Array
// Suppose an array of length n sorted in ascending order is rotated between 1 and n times
// For example, the array nums = [0,1,2,4,5,6,7] might become:
// [4,5,6,7,0,1,2] if it was rotated 4 times.
// [0,1,2,4,5,6,7] if it was rotated 7 times.
// Given the sorted rotated array nums of unique elements, return the minimum element of this array.
// You must write an algorithm that runs in O(log n) time.

public class FindMinimumInRotatedSortedArray
{
    public int FindMin(int[] nums)
    {
        return BinarySearch(nums, 0, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int left, int right)
    {
        if (left == right)
        {
            return nums[left];
        }

        var mid = left + (right - left) / 2;

        if (nums[mid] > nums[right])
        {
            return BinarySearch(nums, mid + 1, right);
        }
        else
        {
            return BinarySearch(nums, left, mid);
        }
    }
}