namespace LeetCode.LeetCode75;

public class EqualRowColumnPairs
{
    public class Solution
    {
        public int EqualPairs(int[][] grid)
        {
            int count = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if (AreEqual(GetRow(grid, i), GetColumn(grid, j)))
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private int[] GetRow(int[][] grid, int index)
        {
            var length = grid.Length;
            
            var a = new int[length];

            for (int i = 0; i < length; i++)
            {
                a[i] = grid[i][index]; 
            }

            return a;
        }

        private int[] GetColumn(int[][] grid, int index)
        {
            var length = grid.Length;
            
            var a = new int[length];

            for (int i = 0; i < length; i++)
            {
                a[i] = grid[index][i]; 
            }

            return a;
        }

        private bool AreEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
