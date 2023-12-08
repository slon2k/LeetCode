namespace LeetCode.LeetCode150.ArrayString;

public class BuySellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            
            int min = int.MaxValue;

            foreach (int item in prices)
            {
                if (item > min) 
                {
                    if (item - min > profit)
                    {
                        profit = item - min;
                    }
                }

                min = item < min ? item : min;
            }

            return profit;
        }
    }
}
