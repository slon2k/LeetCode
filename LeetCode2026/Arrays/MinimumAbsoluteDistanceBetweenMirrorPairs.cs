namespace LeetCode2026.Arrays;

// 3761. Minimum Absolute Distance Between Mirror Pairs
// You are given an integer array nums.
// A mirror pair is a pair of indices (i, j) such that:
// 0 <= i < j < nums.length, and
// reverse(nums[i]) == nums[j], where reverse(x) denotes the integer formed by reversing the digits of x. 
// Leading zeros are omitted after reversing, for example reverse(120) = 21.
// Return the minimum absolute distance between the indices of any mirror pair. The absolute distance between indices i and j is abs(i - j).
// If no mirror pair exists, return -1.

public class MinimumAbsoluteDistanceBetweenMirrorPairsSolution
{
    public int MinMirrorPairDistance(int[] nums)
    {
        var indexMap = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (!indexMap.ContainsKey(nums[i]))
            {
                indexMap[nums[i]] = [];
            }
            indexMap[nums[i]].Add(i);
        }
        
        int minDistance = int.MaxValue;
        
        foreach (var kvp in indexMap)
        {
            int num = kvp.Key;
            int reversedNum = Reverse(num);
            
            if (indexMap.ContainsKey(reversedNum))
            {
                List<int> indices1 = kvp.Value;
                List<int> indices2 = indexMap[reversedNum];
                
                foreach (int i in indices1)
                {
                    foreach (int j in indices2)
                    {
                        if (i < j)
                        {
                            minDistance = Math.Min(minDistance, j - i);
                        }
                    }

                    if (minDistance == 1)
                    {
                        return 1; // Early exit since we can't get smaller than 1
                    }
                }
            }
        }
        
        return minDistance == int.MaxValue ? -1 : minDistance;
    }
    
    private int Reverse(int x)
    {
        int reversed = 0;
        while (x > 0)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }
        return reversed;
    }
}