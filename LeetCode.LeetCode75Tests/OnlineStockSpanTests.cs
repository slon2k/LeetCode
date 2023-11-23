using static LeetCode.LeetCode75.OnlineStockSpan;

namespace LeetCode.LeetCode75Tests;

public class OnlineStockSpanTests
{
    [Theory]
    [InlineData(new int[] { 100, 80, 60, 70, 60, 75, 85 }, new int[] { 1, 1, 1, 2, 1, 4, 6 })]
    [InlineData(new int[] { 31, 41, 48, 59, 79 }, new int[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { 51, 50, 49, 48, 50 }, new int[] { 1, 1, 1, 1, 4 })]
    public void StockSpannerTests(int[] prices, int[] expected)
    {
        var scanner = new StockSpanner(100);

        var results = new List<int>();

        for (int i = 0; i < prices.Length; i++)
        {
            results.Add(scanner.Next(prices[i]));
        }

        Assert.Equal(expected, results);
    }
}
