using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class AsteroidCollisionTests
{
    public class SolutionTest
    {
        [Theory]
        [InlineData(new int[] { 5, 10, -5 }, new int[] { 5, 10 })]
        [InlineData(new int[] { 8, -8 }, new int[] { })]
        [InlineData(new int[] { 10, 2, -5 }, new int[] { 10 })]
        [InlineData(new int[] { -2, -1, 1, 2 }, new int[] { -2, -1, 1, 2 })]
        public void AsteroidCollisionTest(int[] asteroids, int[] expected)
        {
            var solution = new AsteroidCollision.Solution();

            var result = solution.AsteroidCollision(asteroids);

            Assert.Equal(expected, result);
        }
    }
}
