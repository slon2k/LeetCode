namespace LeetCode.LeetCode150.BinarySearch;

public class SearchMatrix
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int height = matrix.Length;
            int width = matrix[0].Length;

            if (target < matrix[0][0] || target > matrix[height - 1][width - 1])
            {
                return false;
            }

            int row = FindRow(matrix, target);

            return Find(matrix, target, row);
        }

        private bool Find(int[][] matrix, int target, int row)
        {
            int left = 0;
            int right = matrix[0].Length - 1;

            if (target < matrix[row][left] || target > matrix[row][right])
            {
                return false;
            }

            if (target == matrix[row][left] || target == matrix[row][right])
            {
                return true;
            }

            while (left < right - 1)
            {
                int middle = left + (right - left) / 2;

                if (matrix[row][middle] == target)
                {
                    return true;
                }

                if (matrix[row][middle] > target )
                {
                    right = middle;
                } else
                {
                    left = middle;
                }
            }

            return false;
        }

        private int FindRow(int[][] matrix, int target)
        {
            int begin = 0;
            
            int end = matrix.Length - 1;

            if (target >= matrix[end][0])
            {
                return end;
            }

            while(begin < end - 1) 
            {
                int middle = end + (begin - end) / 2;

                if (matrix[middle][0] > target)
                {
                    end = middle;
                } else
                {
                    begin = middle;
                }
            }

            return begin;
        }
    }
}
