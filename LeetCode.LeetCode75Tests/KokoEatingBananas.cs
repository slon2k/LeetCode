using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class KokoEatingBananasTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 3, 6, 7, 11 }, 8, 4)]
        [InlineData(new int[] { 30, 11, 23, 4, 20 }, 5, 30)]
        [InlineData(new int[] { 312884470 }, 968709470, 1)]
        [InlineData(new int[] { 332484035, 524908576, 855865114, 632922376, 222257295, 690155293, 112677673, 679580077, 337406589, 290818316, 877337160, 901728858, 679284947, 688210097, 692137887, 718203285, 629455728, 941802184 }, 823855818, 14)]
        public void MinEatingSpeedTest(int[] piles, int h, int expected)
        {
            var solution = new KokoEatingBananas.Solution();

            var result = solution.MinEatingSpeed(piles, h);

            Assert.Equal(expected, result);
        }
    }
}
