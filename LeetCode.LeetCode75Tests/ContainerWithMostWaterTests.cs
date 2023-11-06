using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class ContainerWithMostWaterTests
{
    [Theory]
    [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    public void MaxAreaTest(int[] data, int expected)
    {
        var solution = new ContainerWithMostWater.Solution();

        var result = solution.MaxArea(data);

        Assert.Equal(expected, result);
    }
}
