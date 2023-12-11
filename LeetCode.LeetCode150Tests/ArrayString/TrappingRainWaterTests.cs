using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class TrappingRainWaterTests
{
    [Theory]
    [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    public void TrapTest(int[] height, int expected)
    {
        var solution = new TrappingRainWater.Solution();

        var result = solution.Trap(height);

        Assert.Equal(expected, result);
    }
}
