using LeetCode.LeetCode150.BitManipulation;

namespace LeetCode.LeetCode150Tests.BitManipulation;

public class AddBinaryTests
{
    [Theory]
    [InlineData("1010", "1011", "10101")]
    [InlineData("11", "1", "100")]
    public void AddBinaryTest(string a, string b, string expected)
    {
        var solution = new AddBinary.Solution();

        var result = solution.AddBinary(a, b);

        Assert.Equal(expected, result);
    }
}
