namespace LeetCode.LeetCode150.BinaryTree;
internal class LevelsAverageBinaryTree
{
    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            List<List<int>> result = new();

            int currentLevel = 0;

            if (root is null)
            {
                return new List<double>();
            }

            Queue<(TreeNode node, int level)> queue = new();

            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var (node, level) = queue.Dequeue();

                if (level > currentLevel)
                {
                    result.Add(new List<int>());
                    currentLevel = level;
                }

                result[^1].Add(node.val);
                
                if (node.right is not null)
                {
                    queue.Enqueue((node.right, level + 1));
                }

                if (node.left is not null)
                {
                    queue.Enqueue((node.left, level + 1));
                }
            }

            return result.Select(level => level.Average()).ToList();
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
