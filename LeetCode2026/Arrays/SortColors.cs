namespace LeetCode2026.Arrays;

// 75. Sort Colors
// Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
// You must solve this problem without using the library's sort function.

public class SortColors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            int reds = 0, whites = 0, blues = 0;

            foreach (int num in nums)
            {
                if (num == 0) reds++;
                else if (num == 1) whites++;
                else blues++;
            }

            int index = 0;
            for (int i = 0; i < reds; i++) nums[index++] = 0;
            for (int i = 0; i < whites; i++) nums[index++] = 1;
            for (int i = 0; i < blues; i++) nums[index++] = 2;      
        }
    }
}