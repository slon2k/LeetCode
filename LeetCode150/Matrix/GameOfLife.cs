namespace LeetCode.LeetCode150.Matrix;

public class GameOfLife
{
    public class Solution
    {
        private int height;

        private int width;
        
        private int[][] board;

        public void GameOfLife(int[][] board)
        {
            height = board.Length;
            width = board[0].Length;

            this.board = board;
            
            Calculate();
            Apply();
        }

        private void Apply()
        {
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if (board[i][j] == 2)
                    {
                        board[i][j] = 1;
                    }

                    if (board[i][j] == 3)
                    {
                        board[i][j] = 0;
                    }
                }
            }
        }

        private void Calculate()
        {
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    int liveNeighbors = LiveNeighbors(i, j);

                    if (liveNeighbors <= 1 && board[i][j] == 1)
                    {
                        board[i][j] += 2;
                    }

                    if (liveNeighbors > 3 && board[i][j] == 1)
                    {
                        board[i][j] += 2;
                    }

                    if (liveNeighbors == 3 && board[i][j] == 0)
                    {
                        board[i][j] += 2;
                    }
                }
            }
        }

        private int LiveNeighbors(int x, int y)
        {
            int count = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (IsAlive(i, j) && (i != x || j != y))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private bool IsAlive(int i, int j) => IsOnBoard(i, j) && board[i][j] % 2 == 1;

        private bool IsOnBoard(int x, int y) => x >= 0 && y >= 0 && x < height && y < width;
    }
}
