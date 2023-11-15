using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class SuccessfulPairsSpellsPotionsTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 5, 1, 3 }, new int[] { 1, 2, 3, 4, 5 }, 7, new int[] { 4, 0, 3 })]
        [InlineData(new int[] { 3, 1, 2 }, new int[] { 8, 5, 8 }, 16, new int[] { 2, 0, 2 })]
        public void SuccessfulPairsTest(int[] spells, int[] potions, long success, int[] expected)
        {
            var solution = new SuccessfulPairsSpellsPotions.Solution();

            var result = solution.SuccessfulPairs(spells, potions, success);

            Assert.Equal(expected, result);
        }
    }
}
