namespace LeetCode2026.Arrays;


// 3488. Closest Equal Element Queries
// You are given a circular array nums and an array queries.
// For each query i, you have to find the following:
// The minimum distance between the element at index queries[i] and any other index j in the circular array, where nums[j] == nums[queries[i]]. 
// If no such index exists, the answer for that query should be -1.
// Return an array answer of the same size as queries, where answer[i] represents the result for query i.

public class ClosestEqualElementQueriesSolution
{
    public IList<int> SolveQueries(int[] nums, int[] queries)
    {
        int n = nums.Length;
        var indicesMap = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < n; i++)
        {
            if (!indicesMap.ContainsKey(nums[i]))
            {
                indicesMap[nums[i]] = new List<int>();
            }
            indicesMap[nums[i]].Add(i);
        }
        
        int[] result = new int[queries.Length];
        
        for (int i = 0; i < queries.Length; i++)
        {
            int queryIndex = queries[i];
            int queryValue = nums[queryIndex];
            
            if (!indicesMap.ContainsKey(queryValue) || indicesMap[queryValue].Count == 1)
            {
                result[i] = -1;
                continue;
            }
            
            List<int> indicesList = indicesMap[queryValue];

            int index = indicesList.BinarySearch(queryIndex);
            if (index < 0)
            {
                result[i] = -1;
                continue;
            }

            int left = (index - 1 + indicesList.Count) % indicesList.Count;
            int right = (index + 1) % indicesList.Count;

            int leftDistance = Math.Min(Math.Abs(indicesList[left] - queryIndex), n - Math.Abs(indicesList[left] - queryIndex));
            int rightDistance = Math.Min(Math.Abs(indicesList[right] - queryIndex), n - Math.Abs(indicesList[right] - queryIndex));

            result[i] = Math.Min(leftDistance, rightDistance);
        }
        
        return result;
    }
}