namespace LeetCode2026.Arrays;

// 2615. Sum of Distances
// You are given a 0-indexed integer array nums. 
// There exists an array arr of length nums.length, where arr[i] is the sum of |i - j| over all j such that nums[j] == nums[i] and j != i. 
// If there is no such j, set arr[i] to be 0.
// Return the array arr.

public class SumOfDistances
{
    public long[] Distance(int[] nums) 
    {
        var dict = new Dictionary<int, List<int>>();
        var arr = new long[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = new List<int>();
            }
            dict[nums[i]].Add(i);
        }

        foreach (var list in dict.Values)
        {
            long totalCount = list.Count;
            long leftCount = 0;
            long totalSum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                totalSum += list[i];
            }

            long leftSum = 0;
            long rightSum = totalSum;

            for (int j = 0; j < list.Count; j++)
            {
                int currentIndex = list[j];
                rightSum -= currentIndex;
                long rightCount = totalCount - leftCount - 1;

                arr[currentIndex] = (currentIndex * leftCount - leftSum) + (rightSum - currentIndex * rightCount); 
                leftCount++;
                leftSum += currentIndex;
            }
        }

        return arr;
    }
}