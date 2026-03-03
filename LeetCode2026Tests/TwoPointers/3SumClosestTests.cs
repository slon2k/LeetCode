using Xunit;
using LeetCode2026.TwoPointers;

namespace LeetCode2026Tests.TwoPointers
{
    public class ThreeSumClosestTests
    {
        [Theory]
        [InlineData(new int[] { -1, 2, 1, -4 }, 1, 2)]
        [InlineData(new int[] { 0, 0, 0 }, 1, 0)]
        [InlineData(new int[] { 1, 1, 1, 0 }, -100, 2)]
        [InlineData(new int[] { 1, 2, 5, 10, 11 }, 12, 13)]
        public void ThreeSumClosest_ReturnsExpected(int[] nums, int target, int expected)
        {
            var solution = new SolutionThreeSumClosest();
            var result = solution.ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
