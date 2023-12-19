namespace LeetCode.LeetCode150.Matrix;

public class ValidSudoku
{
    public class Solution
    {
        private readonly string digits = "123456789";

        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (!IsRowValid(i, board) || !IsColValid(i, board))
                {
                    return false;
                }
            }

            for (int i = 0; i < board.Length; i += 3)
            {
                for(int j = 0; j < board.Length; j += 3)
                {
                    if (!IsSubBoxValid(i, j, board))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private bool IsRowValid(int index, char[][] board)
        {
            HashSet<char> used = new();
            
            for (int i = 0; i < board.Length; i++)
            {
                char c = board[index][i];
                
                if (used.Contains(c))
                {
                    return false;
                }

                if (digits.Contains(c))
                {
                    used.Add(c);
                }  
            }

            return true;
        }

        private bool IsColValid(int index, char[][] board)
        {
            HashSet<char> used = new();

            for (int i = 0; i < board.Length; i++)
            {
                char c = board[i][index];

                if (used.Contains(c))
                {
                    return false;
                }

                if (digits.Contains(c))
                {
                    used.Add(c);
                }               
            }

            return true;
        }

        private bool IsSubBoxValid(int row, int col, char[][] board)
        {
            HashSet<char> used = new();

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char c = board[row + i][ col + j];

                    if (used.Contains(c))
                    {
                        return false;
                    }

                    if (digits.Contains(c))
                    {
                        used.Add(c);
                    }
                }
            }

            return true;
        }
    }
}
