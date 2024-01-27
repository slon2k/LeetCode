namespace LeetCode.LeetCode150.Graph;

public class SnakesAndLadders
{
    public class Solution
    {
        public int SnakesAndLadders(int[][] board)
        {
            int size = board.Length;

            int target = size * size;

            int[] path = Fill(board);

            HashSet<int> visited = new();

            Queue<(int cell, int step)> queue = new ();

            queue.Enqueue((1, 0));

            while (queue.Count > 0)
            {
                var (cell, step) = queue.Dequeue();

                if (visited.Contains(cell))
                {
                    continue;
                }

                visited.Add(cell);

                if (cell == target)
                {
                    return step;
                }

                for (int i = cell + 1; i <= Math.Min(cell + 6, target); i++)
                {                  
                    int next = path[i] == 0 ? i : path[i];

                    if (next <= target && !visited.Contains(next))
                    {
                        queue.Enqueue((next, step + 1));
                    }
                }
            }

            return -1;
        }

        private static int[] Fill(int[][] board)
        {
            int size = board.Length;
            
            List<int> path = new() { 0 };

            for (int i = 0; i < size; i++)
            {
                var line = new List<int>(board[size - i - 1]);
                
                if (i % 2 == 1)
                {
                    line.Reverse();
                }

                path.AddRange(line.Select(x => x == -1 ? 0 : x));
            }

            return path.ToArray();
        }
    }
}