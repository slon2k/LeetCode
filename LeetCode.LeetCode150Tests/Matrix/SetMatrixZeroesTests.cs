using LeetCode.LeetCode150.Matrix;

namespace LeetCode.LeetCode150Tests.Matrix;

public class SetMatrixZeroesTests
{
    [Theory]
    [InlineData(new string[] { "0,1,2,0", "3,4,5,2", "1,3,1,5" }, new string[] { "0,0,0,0", "0,4,5,0", "0,3,1,0" })]
    [InlineData(new string[] { "1,1,1", "1,0,1", "1,1,1" }, new string[] { "1,0,1", "0,0,0", "1,0,1" })]
    [InlineData(new string[] { "0,1" }, new string[] { "0,0" })]
    [InlineData(new string[] { "0","1" }, new string[] { "0","0" })]
    [InlineData(new string[] { "1,0,3" }, new string[] { "0,0,0" })]
    public void SetZeroes(string[] matrix, string[] expected)
    {
        var solution = new SetMatrixZeroes.Solution();

        var array = matrix.Select(x => x.Split(',').Select(x => int.Parse(x)).ToArray()).ToArray();

        solution.SetZeroes(array);

        var expectedArray = expected.Select(x => x.Split(',').Select(x => int.Parse(x)).ToArray()).ToArray();

        Assert.Equal(expectedArray, array);
    }
}
