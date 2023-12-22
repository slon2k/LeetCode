namespace LeetCode.LeetCode150.Matrix;

public class SetMatrixZeroes
{
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            bool firstRowHasZero = false;
            bool firstColumnHasZero = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    firstColumnHasZero = true;
                    break;
                }
            }

            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0) 
                {
                    firstRowHasZero = true;
                    break;
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                { 
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;
                        matrix[i][0] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            { 
                if ((matrix[i][0]) == 0)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        matrix[i][(j)] = 0;
                    }
                }
            }

            for (int j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[0][j] == 0)
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (firstColumnHasZero)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }

            if (firstRowHasZero)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[0][i] = 0;
                }
            }
        }
    }
}
