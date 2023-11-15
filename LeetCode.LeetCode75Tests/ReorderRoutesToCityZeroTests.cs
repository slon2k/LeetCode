using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class ReorderRoutesToCityZeroTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(6, new string[] { "0,1", "1,3", "2,3", "4,0", "4,5" },3)]
        [InlineData(5, new string[] { "1,0", "1,2", "3,2", "3,4" }, 2)]
        [InlineData(3, new string[] { "1,0", "2,0" }, 0)]
        public void MinReorderTest(int n, string[] connections, int expected)
        {
            var solution = new ReorderRoutesToCityZero.Solution();

            int[][] array = new int[connections.Length][];
            
            for (int i = 0; i < connections.Length; i++)
            {
                array[i] = connections[i].Split(',').Select(int.Parse).ToArray();
            }

            var result = solution.MinReorder(n, array);

            Assert.Equal(expected, result);
        }
    }
}
