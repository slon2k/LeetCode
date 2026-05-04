namespace LeetCode2026.Strings;

// 48. Rotate Image
// You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

public class RotateImage
{
    public void Rotate(int[][] matrix) 
    {
        int n = matrix.Length;

        // Transpose the matrix
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
            }
        }

        // Reverse each row
        for (int i = 0; i < n; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
}