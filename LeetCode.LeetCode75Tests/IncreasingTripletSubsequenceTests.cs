using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class IncreasingTripletSubsequenceTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, true )]
    [InlineData(new int[] { 5, 4, 3, 2, 1 }, false )]
    [InlineData(new int[] { 2, 1, 5, 0, 4, 6 }, true )]
    [InlineData(new int[] { 6, 7, 1, 2 }, false )]
    public void IncreasingTripletTest(int[] numbers, bool expected)
    {
        var solution = new IncreasingTripletSubsequence.Solution();

        var result = solution.IncreasingTriplet(numbers);

        Assert.Equal(expected, result);
    }
}
