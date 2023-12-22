namespace LeetCode.LeetCode150.Matrix;

public class SpiralMatrix
{
    public class Solution
    {
        private int rows;
        private int columns;

        private bool[,] visited = null!;

        private readonly List<int> result = new();

        public IList<int> SpiralOrder(int[][] matrix)
        {
            rows = matrix.Length;
            columns = matrix[0].Length;

            visited = new bool[rows, columns];

            result.Clear();

            int x = 0, y = -1;

            while(IsFree(x, y + 1))
            {
                while (IsFree(x, y + 1))
                {
                    Visit(x, ++y, matrix);
                }

                while (IsFree(x + 1, y))
                {
                    Visit(++x, y, matrix);
                };

                while (IsFree(x, y - 1))
                {
                    Visit(x, --y, matrix);
                };

                while (IsFree(x - 1, y))
                {
                    Visit(--x, y, matrix);
                };
            }

            return result;

        }

        private bool IsFree(int x, int y)
        {
            if (x < 0 || y < 0 || x >= rows || y >= columns)
            {
                return false;
            }

            return !visited[x, y];
        }

        private void Visit(int x, int y, int[][] matrix)
        {
            result.Add(matrix[x][y]);
            visited[x, y] = true;
        }
    }
}
