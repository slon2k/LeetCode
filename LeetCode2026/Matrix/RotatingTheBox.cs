namespace LeetCode2026.Matrix;

// 1861. Rotating the Box
// You are given an m x n matrix of characters box representing a side-view of a box. Each cell of the box is one of the following:
// - A stone '#'
// - A stationary obstacle '*'  
// - Empty '.'
// The box is rotated 90 degrees clockwise, causing some of the stones to fall due to
// gravity. Each stone falls down until it lands on an obstacle, another stone, or the bottom of the box. Gravity does not affect the obstacles' positions, and the inertia from the rotation does not affect the horizontal positions of the stones.
// It is guaranteed that each stone in box rests on an obstacle, another stone, or the bottom of the box.
// Return an n x m matrix representing the box after the rotation described above.

public class RotatingTheBox
{
    public char[][] RotateTheBox(char[][] box) 
    {
        int m = box.Length;
        int n = box[0].Length;
        for (int row = 0; row < m; row++)
        {
            int writeColumn = n - 1;

            for (int column = n - 1; column >= 0; column--)
            {
                if (box[row][column] == '*')
                {
                    writeColumn = column - 1;
                    continue;
                }

                if (box[row][column] != '#')
                {
                    continue;
                }

                box[row][column] = '.';
                box[row][writeColumn] = '#';
                writeColumn--;
            }
        }

        char[][] rotatedBox = new char[n][];

        for (int row = 0; row < n; row++)
        {
            rotatedBox[row] = new char[m];

            for (int column = 0; column < m; column++)
            {
                rotatedBox[row][column] = box[m - 1 - column][row];
            }
        }

        return rotatedBox;
    }
}