using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class DecodeStringTests
{
    public class SolutionTest
    {
        [Theory]
        [InlineData("3[a]2[bc]", "aaabcbc")]
        [InlineData("3[a2[c]]", "accaccacc")]
        [InlineData("2[abc]3[cd]ef", "abcabccdcdcdef")]
        [InlineData("2[bc]12[a]", "bcbcaaaaaaaaaaaa")]
        public void DecodeStringTest(string s, string expected)
        {
            var solution = new DecodeString.Solution();

            var result = solution.DecodeString(s);

            Assert.Equal(expected, result);
        }
    }
}
