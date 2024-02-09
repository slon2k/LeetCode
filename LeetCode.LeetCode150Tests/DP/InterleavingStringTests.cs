using LeetCode.LeetCode150.DP;

namespace LeetCode.LeetCode150Tests.DP;

public class InterleavingStringTests
{
    [Theory]
    [InlineData("aabcc", "dbbca", "aadbbcbcac", true)]
    [InlineData("aabcc", "dbbca", "aadbbbaccc", false)]
    [InlineData("aaaa", "aa", "aaa", false)]
    [InlineData(
        "bbbbbabbbbabaababaaaabbababbaaabbabbaaabaaaaababbbababbbbbabbbbababbabaabababbbaabababababbbaaababaa",
        "babaaaabbababbbabbbbaabaabbaabbbbaabaaabaababaaaabaaabbaaabaaaabaabaabbbbbbbbbbbabaaabbababbabbabaab",
        "babbbabbbaaabbababbbbababaabbabaabaaabbbbabbbaaabbbaaaaabbbbaabbaaabababbaaaaaabababbababaababbababbbababbbbaaaabaabbabbaaaaabbabbaaaabbbaabaaabaababaababbaaabbbbbabbbbaabbabaabbbbabaaabbababbabbabbab",
        false
        )]
    [InlineData("", "", "", true)]
    public void IsInterleave(string s1, string s2, string s3, bool expected)
    {
        var solution = new InterleavingString.Solution();

        var result = solution.IsInterleave(s1, s2, s3);

        Assert.Equal(expected, result);
    }
}
