using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class DailyTemperaturesTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }, new int[] { 1, 1, 4, 2, 1, 1, 0, 0 })]
        [InlineData(new int[] { 30, 40, 50, 60 }, new int[] { 1, 1, 1, 0 })]
        [InlineData(new int[] { 30, 60, 90 }, new int[] { 1, 1, 0 })]
        public void  DailyTemperaturesTest(int[] temperatures, int[] expected)
        {
            var soulution = new DailyTemperatures.Solution();

            var result = soulution.DailyTemperatures(temperatures);

            Assert.Equal(expected, result);
        }
    }
}
