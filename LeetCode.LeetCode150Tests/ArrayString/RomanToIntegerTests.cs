using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("XXVII", 27)]
    [InlineData("LVIII", 58)]
    [InlineData("XLVIII", 48)]
    [InlineData("CDIX", 409)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt(string s, int expected)
    {
        var solution = new RomanToInteger.Solution();

        var result = solution.RomanToInt(s);

        Assert.Equal(expected, result);
    }
}
