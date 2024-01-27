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
        private readonly List<List<int>> board1 = new()
        {
            new List<int> { -1, -1, -1, -1, -1, -1 },
            new List<int> { -1, -1, -1, -1, -1, -1 },
            new List<int> { -1, -1, -1, -1, -1, -1 },
            new List<int> { -1, 35, -1, -1, 13, -1 },
            new List<int> { -1, -1, -1, -1, -1, -1 },
            new List<int> { -1, 15, -1, -1, -1, -1 }
        };

        private readonly List<List<int>> board2 = new()
        {
            new List<int> { -1, -1 },
            new List<int> { -1, 3 },
        };

        private readonly List<List<int>> board3 = new()
        {
            new List<int> { 1, 1, -1 },
            new List<int> { 1, 1, 1 },
            new List<int> { -1, 1, 1 },
        };

        private static List<List<int>> GetBoard4()
        {
            var board = new List<List<int>>();

            for (int i = 0; i < 20; i++)
            {
                board.Add(Enumerable.Repeat(-1, 20).ToList());
            }

            return board;
        }

        public SnakesAndLaddersTestData()
        {
            Add(board1.Select(x => x.ToArray()).ToArray(), 4);
            Add(board2.Select(x => x.ToArray()).ToArray(), 1);
            Add(board3.Select(x => x.ToArray()).ToArray(), -1);
            Add(GetBoard4().Select(x => x.ToArray()).ToArray(), 67);
        }
    }
}
