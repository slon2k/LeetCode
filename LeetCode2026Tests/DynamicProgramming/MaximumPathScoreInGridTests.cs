using LeetCode2026.DynamicProgramming;

namespace LeetCode2026Tests.DynamicProgramming;

public class MaximumPathScoreInGridTests
{
    [Fact]
    public void MaxPathScore_Returns2_ForFirstProvidedCase()
    {
        var sut = new MaximumPathScoreInGrid();

        int[][] grid =
        [
            [0, 1],
            [2, 0]
        ];

        var actual = sut.MaxPathScore(grid, 1);

        Assert.Equal(2, actual);
    }

    [Fact]
    public void MaxPathScore_ReturnsMinus1_ForSecondProvidedCase()
    {
        var sut = new MaximumPathScoreInGrid();

        int[][] grid =
        [
            [0, 1],
            [1, 2]
        ];

        var actual = sut.MaxPathScore(grid, 1);

        Assert.Equal(-1, actual);
    }
}
