using LeetCode.LeetCode150.BitManipulation;

namespace LeetCode.LeetCode150Tests.BitManipulation;

public class NumbersRangeBitwiseAndTests
{
    [Theory]
    [InlineData(5, 7, 4)]
    public void RangeBitwiseAndTest(int left, int right, int expected)
    {
        var solution = new NumbersRangeBitwiseAnd.Solution();

        var result = solution.RangeBitwiseAnd(left, right);

        Assert.Equal(expected, result);
    }
}
