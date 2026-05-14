using LeetCode2026.Arrays;

namespace LeetCode2026Tests.Arrays;

public class MinimumMovesToMakeArrayComplementaryTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 4, 3 }, 4, 1)]
    [InlineData(new[] { 1, 2, 2, 1 }, 2, 2)]
    [InlineData(new[] { 1, 2, 1, 2 }, 2, 0)]
    [InlineData(new[] { 2, 2, 2, 2 }, 2, 0)]
    [InlineData(new[] { 1, 5, 1, 5 }, 5, 0)]
    [InlineData(new[] { 1, 5, 2, 4 }, 5, 1)]
    [InlineData(new[] { 20744,7642,19090,9992,2457,16848,3458,15721 }, 22891, 4)]
    public void MinMoves_ReturnsExpected(int[] nums, int limit, int expected)
    {
        var sut = new MinimumMovesToMakeArrayComplementary();

        var actual = sut.MinMoves(nums, limit);

        Assert.Equal(expected, actual);
    }
}
