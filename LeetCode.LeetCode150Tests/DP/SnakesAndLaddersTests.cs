using LeetCode.LeetCode150.Graph;

namespace LeetCode.LeetCode150Tests.DP;

public class SnakesAndLaddersTests
{
    [Theory]
    [ClassData(typeof(SnakesAndLaddersTestData))]
    public void SnakesAndLaddersTest(int[][] board, int expected)
    {
        var solution = new SnakesAndLadders.Solution();

        var result = solution.SnakesAndLadders(board);

        Assert.Equal(expected, result);
    }

    public class SnakesAndLaddersTestData : TheoryData<int[][], int>
    {
        private readonly int[][] board1 =
        [
            [-1, -1, -1, -1, -1, -1],
            [-1, -1, -1, -1, -1, -1],
            [-1, -1, -1, -1, -1, -1],
            [-1, 35, -1, -1, 13, -1],
            [-1, -1, -1, -1, -1, -1],
            [-1, 15, -1, -1, -1, -1]
        ];

        private readonly int[][] board2 =
        [
            [-1, -1],
            [-1, 3],
        ];

        private readonly int[][] board3 =
        [
            [1, 1, -1],
            [1, 1, 1],
            [-1, 1, 1],
        ];

        private static int[][] Board4 => Enumerable.Repeat(Enumerable.Repeat(-1, 20).ToArray(), 20).ToArray();

        public SnakesAndLaddersTestData()
        {
            Add(board1, 4);
            Add(board2, 1);
            Add(board3, -1);
            Add(Board4, 67);
        }
    }
}
