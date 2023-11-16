using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class CombinationSumTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(3, 9, new string[] { "1,2,6", "1,3,5", "2,3,4"})]
        [InlineData(3, 7, new string[] { "1,2,4" })]
        public void CombinationSum3Test(int k, int n, string[] expected)
        {
            var solution = new CombinationSum.Solution();

            var result = solution.CombinationSum3(k, n);

            var expectedList = expected.Select(x => x.Split(',').Select(x => int.Parse(x)));

            Assert.Equal(expectedList, result);
        }
    }
}
