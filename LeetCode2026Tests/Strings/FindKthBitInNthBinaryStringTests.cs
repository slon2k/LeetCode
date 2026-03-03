using Xunit;
using LeetCode2026.Strings;

namespace LeetCode2026Tests.Strings
{
    public class FindKthBitInNthBinaryStringTests
    {
        [Theory]
        [InlineData(1, 1, '0')]
        [InlineData(2, 1, '0')]
        [InlineData(2, 2, '1')]
        [InlineData(3, 1, '0')]
        [InlineData(3, 2, '1')]
        [InlineData(3, 3, '1')]
        [InlineData(3, 4, '1')]
        [InlineData(4, 5, '0')]
        [InlineData(4, 8, '1')]
        [InlineData(4, 11, '1')]
        public void FindKthBit_ReturnsExpected(int n, int k, char expected)
        {
            var solution = new FindKthBitInNthBinaryString.Solution();
            var result = solution.FindKthBit(n, k);
            Assert.Equal(expected, result);
        }
    }
}
