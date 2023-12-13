using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class ZigzagConversionTests
{
    [Theory]
    [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [InlineData("A", 1, "A")]
    public void ConvertTest(string s, int numRows, string expected)
    {
        var solution = new ZigzagConversion.Solution();

        var result = solution.Convert(s, numRows);

        Assert.Equal(expected, result);
    }
}
