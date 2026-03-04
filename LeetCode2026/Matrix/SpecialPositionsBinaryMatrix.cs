namespace LeetCode2026.Matrix;

// 1582. Special Positions in a Binary Matrix
// Given a rows x cols binary matrix mat, return the number of special positions in mat.
// A position (i,j) is called special if mat[i][j] == 1 and all other elements in row i and column j are 0 (rows and columns are 0-indexed).
public class SpecialPositionsBinaryMatrix
{
    public class Solution 
    {
        // O(m*n) time, O(m+n) space
        public int NumSpecial(int[][] mat)
        {
            int result = 0;
            int m = mat.Length, n = mat[0].Length;
            int[] rowCount = new int[m];
            int[] colCount = new int[n];

            // Count the number of 1s in each row and column
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        rowCount[i]++;
                        colCount[j]++;
                    }
                }
            }

            // Count the number of special positions
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 1 && rowCount[i] == 1 && colCount[j] == 1)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}