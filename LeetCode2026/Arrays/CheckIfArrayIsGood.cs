namespace LeetCode2026.Arrays;

// 2784. Check if Array is Good
// You are given an integer array nums. We consider an array good if it is a permutation of an array base[n].
// base[n] = [1, 2, ..., n - 1, n, n] (in other words, it is an array of length n + 1 which contains 1 to n - 1 exactly once, plus two occurrences of n). 
// For example, base[1] = [1, 1] and base[3] = [1, 2, 3, 3].

// Return true if the given array is good, otherwise return false.

public class CheckIfArrayIsGood
{
    public bool IsGood(int[] nums)
    {
        int n = nums.Length;
        
        if (n < 2)
        {
            return false;
        }
        var maxValue = n - 1;
        var maxValueCount = 0;
        var seen = new HashSet<int>();

        foreach (var num in nums)
        {
            if (num < 1 || num > maxValue)
            {
                return false;
            }
            if (num == maxValue)
            {
                maxValueCount++;
                if (maxValueCount > 2)
                {
                    return false;
                }
            }
            else
            {
                if (!seen.Add(num))
                {
                    return false;
                }
            }
        }

        return maxValueCount == 2 && seen.Count == maxValue - 1;
    }
}