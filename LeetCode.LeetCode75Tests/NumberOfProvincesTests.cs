using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class NumberOfProvincesTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new string[] { "1,1,0", "1,1,0", "0,0,1" }, 2)]
        [InlineData(new string[] { "1,0,0", "0,1,0", "0,0,1" }, 3)]
        public void FindCircleNumTest(string[] isConnected, int expected)
        {
            var solution = new NumberOfProvinces.Solution();

            int[][] array = new int[isConnected.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = isConnected[i].Split(',').Select(x => int.Parse(x)).ToArray();
            }

            var result = solution.FindCircleNum(array);

            Assert.Equal(expected, result);
        }
    }
}
