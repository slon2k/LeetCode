namespace LeetCode2026.Matrix;

// 59. Spiral Matrix II
// Given an integer n, generate an n x n matrix filled with elements from 1 to n^2 in spiral order.

public class SpiralMatrix
{
    public class Solution 
    {
        private int count = 1;
        private int col = 0;
        private int row = 0;

        public int[][] GenerateMatrix(int n)
        {
            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            
            matrix[row][col] = count++;

            while (count <= n * n)
            {
                MoveRight(matrix);
                MoveDown(matrix);
                MoveLeft(matrix);
                MoveUp(matrix);
            }

            return matrix;
        }

        private void MoveRight(int[][] matrix)
        {
            while (col < matrix[row].Length - 1 && matrix[row][col + 1] == 0)
            {
                col++;
                matrix[row][col] = count++;
            }
        }

        private void MoveDown(int[][] matrix)
        {
            while (row < matrix.Length - 1 && matrix[row + 1][col] == 0)
            {
                row++;
                matrix[row][col] = count++;
            }
        }

        private void MoveLeft(int[][] matrix)
        {
            while (col > 0 && matrix[row][col - 1] == 0)
            {
                col--;
                matrix[row][col] = count++;
            }
        }

        private void MoveUp(int[][] matrix)
        {
            while (row > 0 && matrix[row - 1][col] == 0)
            {
                row--;
                matrix[row][col] = count++;
            }
        }
    }
}