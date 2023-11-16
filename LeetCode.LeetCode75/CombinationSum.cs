namespace LeetCode.LeetCode75;

public class CombinationSum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<int> digits = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            IList<IList<int>> combinations = new List<IList<int>>()
            {
                new List<int>(){ 1 },
                new List<int>(){ 2 },
                new List<int>(){ 3 },
                new List<int>(){ 4 },
                new List<int>(){ 5 },
                new List<int>(){ 6 },
                new List<int>(){ 7 },
                new List<int>(){ 8 },
            };
            
            for (int i = 2; i <= k; i++) 
            {
                IList<IList<int>> newList = new List<IList<int>>();

                foreach (var combination in combinations)
                {
                    for (int j = combination.Last() + 1; j < 10; j++)
                    {
                        var sum = combination.Sum() + j;

                        if (sum <= n)
                        {
                            newList.Add(new List<int>(combination) { j });
                        }
                    }
                }

                combinations = newList;
            }

            return combinations.Where(c => c.Sum() == n).ToList();
        }
    }
}
