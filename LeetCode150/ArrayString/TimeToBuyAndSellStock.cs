namespace LeetCode.LeetCode150.ArrayString;

public class TimeToBuyAndSellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int prev = int.MaxValue;

            foreach(int price in prices)
            {
                if (price > prev)
                {
                    profit += price - prev;
                }

                prev = price;
            }

            return profit;
        }
    }
}
