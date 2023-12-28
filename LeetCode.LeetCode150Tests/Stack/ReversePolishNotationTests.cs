using LeetCode.LeetCode150.Stack;

namespace LeetCode.LeetCode150Tests.Stack;
public class ReversePolishNotationTests
{
    [Theory]
    [InlineData(new string[] { "4", "13", "5", "/", "+" }, 6)]
    [InlineData(new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }, 22)]
    public void EvalRPN(string[] tokens, int expected)
    {
        var solution = new ReversePolishNotation.Solution();

        var result = solution.EvalRPN(tokens);

        Assert.Equal(expected, result);
    }
}
