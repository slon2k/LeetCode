namespace LeetCode.LeetCode150.Backtracking;

public class CombinationSum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            Array.Sort(candidates);

            if (candidates.Length ==  0 || target < candidates[0] )
            {
                return result;
            }

            int candidate = candidates[0];

            if (candidate == target)
            {
                result.Add(new List<int>() { target });
            }

            foreach (var item in CombinationSum(candidates, target - candidate))
            {
                item.Add(candidate);
                result.Add(item);
            }

            foreach (var item in CombinationSum(candidates[1..], target))
            {
                result.Add(item);
            }

            return result;
        }
    }
}
