using System.Text;

namespace LeetCode.LeetCode150.ArrayString;

public class ZigzagConversion
{
    public class Solution
    {
        private char[,] array;

        private int a, b, count;

        public string Convert(string s, int numRows)
        {
            if (numRows == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numRows));
            }

            if (numRows == 1)
            {
                return s;
            }

            int rows = numRows;
            
            int columns = s.Length;

            array = new char[rows, columns];

            Fill(rows, columns);

            a = -1; b = 0; count = 0;

            while (count < s.Length)
            {
                while (a < rows - 1 && count < s.Length)
                {
                    MoveDown(s[count]);
                }

                while(a > 0 && count < s.Length)
                {
                    MoveUp(s[count]);
                }
            }

            return GetResult(rows, columns);
        }

        private void MoveDown(char c)
        {
            array[++a, b] = c;
            count++;
        }

        private void MoveUp(char c)
        {
            array[--a, ++b] = c;
            count++;
        }

        private void Fill(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = '\0';
                }
            }
        }

        private string GetResult(int rows, int columns)
        {
            var str = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(array[i, j] != '\0')
                    {
                        str.Append(array[i, j]);
                    }
                }
            }

            return str.ToString();
        }
    }
}
