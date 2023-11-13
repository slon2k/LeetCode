using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class RottingOrangesTests
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new string[] { "2,1,1", "1,1,0", "0,1,1" }, 4)]
        [InlineData(new string[] { "2,1,1", "0,1,1", "1,0,1" }, -1)]
        [InlineData(new string[] { "0,2" }, 0)]
        [InlineData(new string[] { "2,2", "1,1", "0,0", "2,0" }, 1)]
        public void OrangesRottingTest(string[] grid, int expected)
        {
            var solution = new RottingOranges.Solution();

            int[][] array = new int[grid.Length][];

            for (int i = 0; i < grid.Length; i++)
            {
                array[i] = grid[i].Split(',').Select(x => int.Parse(x)).ToArray(); 
            }

            var result = solution.OrangesRotting(array);

            Assert.Equal(expected, result);
        }
    }
}
