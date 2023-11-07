namespace LeetCode.LeetCode75;

public class UniqueNumberOfOccurrences
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            var occurrencesSet = new HashSet<int>();

            foreach (int item in arr)
            {
                if (occurrences.ContainsKey(item)) 
                {
                    occurrences[item]++;
                } else
                {
                    occurrences[item] = 1;
                }
            }

            foreach (int item in occurrences.Values)
            {
                if (!occurrencesSet.Contains(item))
                {
                    occurrencesSet.Add(item);
                } else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
