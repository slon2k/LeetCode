
namespace LeetCode.LeetCode150.Backtracking;

public class WordSearch
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for(int j = 0; j < board[i].Length; j++)
                {
                    if (FindWord(board, word, i, j))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool FindWord(char[][] board, string word, int a, int b)
        {
            if (word.Length == 0)
            {
                return false;
            }

            Queue<(int, int, string, HashSet<(int, int)>)> queue = new();

            queue.Enqueue((a, b, "", new HashSet<(int, int)>()));

            while (queue.Count > 0)
            {
                var (x, y, current, visited) = queue.Dequeue();

                if (visited.Contains((x, y)))
                {
                    continue;
                }

                visited.Add((x, y));

                current += board[x][y];

                if (current == word)
                {
                    return true;
                }

                if (current != word[..current.Length])
                {
                    continue;
                }

                foreach (var (x1, y1) in GetNeighbors(x, y, board))
                {
                    if (!visited.Contains((x1, y1)))
                    {
                        queue.Enqueue((x1, y1, current, new HashSet<(int, int)>(visited)));
                    }
                }
            }

            return false;
        }

        private static IEnumerable<(int x, int y)> GetNeighbors(int a, int b, char[][] board)
        {
            int height = board.Length;
            int width = board[0].Length;

            if(IsInRange(a - 1, 0, height))
            {
                yield return (a - 1, b);
            }

            if(IsInRange(a + 1, 0, height))
            {
                yield return (a + 1, b);
            }

            if(IsInRange(b - 1, 0, width))
            {
                yield return (a, b - 1);
            }

            if(IsInRange(b + 1, 0, width))
            {
                yield return (a, b + 1);
            }

        }

        private static bool IsInRange(int a, int min, int max) => a < max && a >= min;
    }
}
