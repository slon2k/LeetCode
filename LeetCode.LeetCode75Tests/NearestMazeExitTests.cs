using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class NearestMazeExitTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { "++.+", "...+", "+++." }, new int[] { 1, 2 }, 1)]
        [InlineData(new string[] { "+++", "...", "+++" }, new int[] { 1, 0 }, 2)]
        [InlineData(new string[] { ".+" }, new int[] { 0, 0 }, -1)]
        public void NearestExit(string[] maze, int[] entrance, int expected)
        {
            var solution = new NearestMazeExit.Solution();

            char[][] array = new char[maze.Length][];

            for (int i = 0; i < maze.Length; i++)
            {
                array[i] = maze[i].ToCharArray();
            }

            var result = solution.NearestExit(array, entrance);

            Assert.Equal(expected, result);
        }
    }
}
