using Xunit;
using LeetCode2026.Strings;

namespace LeetCode2026Tests.Strings
{
    public class CountAndSayTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "11")]
        [InlineData(3, "21")]
        [InlineData(4, "1211")]
        [InlineData(5, "111221")]
        [InlineData(6, "312211")]
        public void CountAndSay_ReturnsExpectedResult(int n, string expected)
        {
            var solution = new CountAndSay.Solution();
            var result = solution.CountAndSay(n);
            Assert.Equal(expected, result);
        }
    }
}
