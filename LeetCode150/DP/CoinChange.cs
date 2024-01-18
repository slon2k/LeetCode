
namespace LeetCode.LeetCode150.DP;

internal class CoinChange
{
    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
            HashSet<int> coinSet = new(coins);

            Dictionary<int, int> results = new();

            return GetResult(amount, coinSet, results);
        }

        private static int GetResult(int amount, HashSet<int> coins, Dictionary<int, int> results)
        {
            if(amount < 0)
            {
                return -1;
            }

            if (amount == 0)
            {
                return 0;
            }

            if (coins.Contains(amount))
            {
                return 1;
            }

            if (results.ContainsKey(amount))
            {
                return results[amount];
            }

            int min = int.MaxValue;

            foreach(int coin in coins)
            {
                int reduced = amount - coin;
                
                if (reduced > 0)
                {
                    var result = GetResult(reduced, coins, results);

                    if (result != -1 && result < min)
                    {
                        min = result;
                    }
                }
            }

            results[amount] = min < int.MaxValue ? min + 1 : -1;

            return results[amount];
        }
    }
}
