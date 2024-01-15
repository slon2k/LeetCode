namespace LeetCode.LeetCode150.Graph;

internal class MinimumGeneticMutation
{
    public class Solution
    {
        public int MinMutation(string startGene, string endGene, string[] bank)
        {
            Queue<(string, int)> queue = new();
            HashSet<string> visited = new();

            queue.Enqueue((startGene, 0));

            while (queue.Count > 0)
            {
                var (currentGene, step) = queue.Dequeue();

                if (!visited.Contains(currentGene))
                {
                    visited.Add(currentGene);

                    if (currentGene == endGene)
                    {
                        return step;
                    }

                    foreach (var gene in bank)
                    {
                        if (!visited.Contains(gene) && CanMutate(currentGene, gene))
                        {
                            queue.Enqueue((gene, step + 1));
                        }
                    }
                }
            }

            return -1;
        }

        private bool CanMutate(string start, string end)
        {
            if (start.Length != end.Length)
            {
                return false;
            }

            int count = 0;

            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] != end[i])
                {
                    count++;
                }
            }

            return count == 1;
        }
    }
}
