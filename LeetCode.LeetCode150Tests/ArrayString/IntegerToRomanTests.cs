using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class IntegerToRomanTests
{
    [Theory]
    [InlineData(3, "III")]
    [InlineData(27, "XXVII")]
    [InlineData(58, "LVIII")]
    [InlineData(48, "XLVIII")]
    [InlineData(409, "CDIX")]
    [InlineData(1994, "MCMXCIV")]
    [InlineData(2000, "MM")]
    public void IntegerToRomanTest(int num, string expected)
    {
        var solution = new IntegerToRoman.Solution();

        var result = solution.IntToRoman(num);

        Assert.Equal(expected, result);
    }
}
