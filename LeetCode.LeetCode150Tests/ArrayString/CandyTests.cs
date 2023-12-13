using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class CandyTests
{
    [Theory]
    [InlineData(new int[] { 1, 0, 2 }, 5)]
    [InlineData(new int[] { 1, 2, 2 }, 4)]
    [InlineData(new int[] { 1, 3, 4, 5, 2 }, 11)]
    [InlineData(new int[] { 0 }, 1)]
    public void CandyTest(int[] ratings, int expected)
    {
        var solution = new Candy.Solution();

        var result = solution.Candy(ratings);

        Assert.Equal(expected, result);
    }
}