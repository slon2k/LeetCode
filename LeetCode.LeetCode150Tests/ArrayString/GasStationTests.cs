using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class GasStationTests
{
    public class Solution
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 1, 2 }, 3)]
        [InlineData(new int[] { 2, 3, 4 }, new int[] { 3, 4, 3 }, -1)]
        public void CanCompleteCircuitTest(int[] gas, int[] cost, int expected)
        {
            var solution = new GasStation.Solution();

            var result = solution.CanCompleteCircuit(gas, cost);

            Assert.Equal(expected, result);
        }
    }
}
