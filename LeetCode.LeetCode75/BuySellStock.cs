namespace LeetCode.LeetCode75;

public class BuySellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices, int fee)
        {
            int length = prices.Length;

            int[] resultWithStock = new int[length];
            int[] resultWithoutStock = new int[length];

            resultWithoutStock[0] = 0;
            resultWithStock[0] = -prices[0];

            for (int i = 1; i < length; i++)
            {
                resultWithoutStock[i] = Math.Max(resultWithoutStock[i - 1], prices[i] + resultWithStock[i - 1] - fee);
                resultWithStock[i] = Math.Max(resultWithoutStock[i - 1] - prices[i], resultWithStock[i - 1]);
            }

            return Math.Max(resultWithoutStock[length - 1], resultWithStock[length - 1] + prices[length - 1] - fee);
        }
    }
}
