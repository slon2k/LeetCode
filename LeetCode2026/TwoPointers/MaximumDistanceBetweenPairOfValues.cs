namespace LeetCode2026.TwoPointers;

// 1855. Maximum Distance Between a Pair of Values
// You are given two non-increasing 0-indexed integer arrays nums1 and nums2
// Return the maximum distance of a pair of indices (i, j) such that i <= j and nums1[i] <= nums2[j]. 
// If there are no valid pairs, return 0.

public class MaximumDistanceBetweenPairOfValuesSolution
{
    public int MaxDistance(int[] nums1, int[] nums2)
    {
        int i = 0, j = 0, maxDistance = 0;
        
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] <= nums2[j])
            {
                maxDistance = Math.Max(maxDistance, j - i);
                j++;
            }
            else
            {
                i++;
            }
        }
        
        return maxDistance;
    }
}
