namespace LeetCode.LeetCode75;

public class KidsWithCandies
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            var result = new List<bool>();

            foreach (var kidCandy in candies)
            {
                if (kidCandy + extraCandies < max)
                {
                    result.Add(false);
                } else
                {
                    result.Add(true);
                }
            }

            return result;
        }
    }
}
