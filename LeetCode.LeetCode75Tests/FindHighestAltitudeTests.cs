using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class FindHighestAltitudeTests
{
    [Theory]
    [InlineData(new int[] { -5, 1, 5, 0, -7 }, 1)]
    [InlineData(new int[] { -4, -3, -2, -1, 4, 3, 2 }, 0)]
    public void LargestAltitudeTest(int[] gain, int expected)
    {
        var solution = new FindHighestAltitude.Solution();

        var result = solution.LargestAltitude(gain);

        Assert.Equal(expected, result);
    }
}
