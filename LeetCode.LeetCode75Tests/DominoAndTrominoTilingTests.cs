using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class DominoAndTrominoTilingTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 5)]
    [InlineData(4, 11)]
    [InlineData(6, 53)]
    public void NumTilingsTest(int n, int expected)
    {
        var solution = new DominoAndTrominoTiling.Solution();

        var result = solution.NumTilings(n);

        Assert.Equal(expected, result);
    }
}
