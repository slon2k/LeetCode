using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class MoveZeroesTests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [InlineData(new int[] { 0 }, new int[] { 0 })]
    [InlineData(new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 })]
    [InlineData(new int[] { 0, 1, 0, 0, 2, 0, 3 }, new int[] { 1, 2, 3, 0, 0, 0, 0 })]
    [InlineData(new int[] { 1, 0, 0, 2, 0, 3, 4, 0, 0, 5, 6, 0 }, new int[] { 1, 2, 3, 4, 5, 6, 0, 0, 0, 0, 0, 0 })]
    public void MoveZeroesTest(int[] numbers, int[] expected)
    {
        var solution = new MoveZeroes.Solution();

        solution.MoveZeroes(numbers);

        Assert.Equal(expected, numbers);
    }
}
