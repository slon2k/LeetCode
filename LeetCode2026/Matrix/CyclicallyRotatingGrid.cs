namespace LeetCode2026.Matrix;

// 1914. Cyclically Rotating a Grid
// You are given an m x n integer matrix grid​​​, where m and n are both even integers, and an integer k.
// The matrix is composed of several layers. 
// A cyclic rotation of the matrix is done by cyclically rotating each layer in the matrix. 
// To cyclically rotate a layer once, each element in the layer will take the place of the adjacent element in the counter-clockwise direction.
// Return the matrix after applying cyclic rotations k times.

public class CyclicallyRotatingGrid
{
    public int[][] RotateGrid(int[][] grid, int k)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        for (int layer = 0; layer < Math.Min(m, n) / 2; layer++)
        {
            var elements = new List<int>();

            // Collect elements of the current layer
            for (int j = layer; j < n - layer; j++)
            {
                elements.Add(grid[layer][j]);
            }
            for (int i = layer + 1; i < m - layer - 1; i++)
            {
                elements.Add(grid[i][n - layer - 1]);
            }
            for (int j = n - layer - 1; j >= layer; j--)
            {
                elements.Add(grid[m - layer - 1][j]);
            }
            for (int i = m - layer - 2; i > layer; i--)
            {
                elements.Add(grid[i][layer]);
            }

            int totalElements = elements.Count;
            int rotations = k % totalElements;

            // Rotate the elements
            var rotatedElements = new List<int>();
            for (int i = 0; i < totalElements; i++)
            {
                rotatedElements.Add(elements[(i + rotations) % totalElements]);
            }

            // Place rotated elements back into the grid
            int index = 0;
            for (int j = layer; j < n - layer; j++)
            {
                grid[layer][j] = rotatedElements[index++];
            }
            for (int i = layer + 1; i < m - layer - 1; i++)
            {
                grid[i][n - layer - 1] = rotatedElements[index++];
            }
            for (int j = n - layer - 1; j >= layer; j--)
            {
                grid[m - layer - 1][j] = rotatedElements[index++];
            }
            for (int i = m - layer - 2; i > layer; i--)
            {
                grid[i][layer] = rotatedElements[index++];
            }
        }

        return grid;
    }
}