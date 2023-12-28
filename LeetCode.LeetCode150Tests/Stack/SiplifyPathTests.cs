using LeetCode.LeetCode150.Stack;

namespace LeetCode.LeetCode150Tests.Stack;

public class SiplifyPathTests
{
    [Theory]
    [InlineData("/home/", "/home")]
    [InlineData("/../", "/")]
    [InlineData("/home//foo/", "/home/foo")]
    [InlineData("/a/../../b/../c//.//", "/c")]
    public void SimplifyPathTest(string path, string expected)
    {
        var solution = new SimplifyPath.Solution();

        var result = solution.SimplifyPath(path);

        Assert.Equal(expected, result);
    }
}
