using LeetCode.LeetCode150.Matrix;

namespace LeetCode.LeetCode150Tests.Matrix;

public class SpiralMatrixTests
{
    [Theory]
    [InlineData(new string[] { "1,2,3", "4,5,6", "7,8,9" }, new int[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 })]
    [InlineData(new string[] { "1,2,3,4", "5,6,7,8", "9,10,11,12" }, new int[] { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 })]
    public void SpiralOrderTest(string[] matrix, int[] expected)
    {
        var solution = new SpiralMatrix.Solution();

        int[][] array = matrix.Select(x => x.Split(',')
            .Select(n => int.Parse(n)).ToArray())
            .ToArray();

        var result = solution.SpiralOrder(array);

        Assert.Equal(expected, result);
    }
}
