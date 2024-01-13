
namespace LeetCode.LeetCode150.Graph;

public class SurroundedRegions
{
    public class Solution
    {
        private int height;
        private int width;

        public void Solve(char[][] board)
        {
            height = board.Length;
            width = board[0].Length;

            foreach (var (x, y) in GetBorderCells())
            {
                if (board[x][y] == 'O')
                {
                    Traverse(x, y, board);
                }
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }

                    if (board[i][j] == '1')
                    {
                        board[i][j] = 'O';
                    }
                }
            }
        }

        private void Traverse(int i, int j, char[][] board)
        {
            Stack<(int, int)> stack = new();

            stack.Push((i, j));

            while (stack.Count > 0)
            {
                var (x, y) = stack.Pop();

                if (board[x][y] == 'O')
                {
                    board[x][y] = '1';

                    foreach (var (a, b) in GetNeighbors(x, y))
                    {
                        if (board[a][b] == 'O')
                        {
                            stack.Push((a, b));
                        }
                    }
                }
            }
        }

        private IEnumerable<(int, int)> GetNeighbors(int x, int y)
        {
            if (IsInRange(x - 1, y))
            {
                yield return (x - 1, y);
            }

            if (IsInRange(x + 1, y))
            {
                yield return (x + 1, y);
            }

            if (IsInRange(x, y - 1))
            {
                yield return (x, y - 1);
            }

            if (IsInRange(x, y + 1))
            {
                yield return (x, y + 1);
            }

        }

        private bool IsInRange(int x, int y) => x >= 0 && y >= 0 && x < height && y < width;

        private IEnumerable<(int, int)> GetBorderCells()
        {
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++) 
                {
                    if (i == 0 || j == 0 || i == height - 1 || j == width - 1)
                    {
                        yield return (i, j);
                    }
                   
                }
            }
        } 
    }
}
