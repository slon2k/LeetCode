namespace LeetCode.LeetCode75;

public class MaximumLevelSum
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public int MaxLevelSum(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            Queue<TreeNode> queue = new();

            Dictionary<TreeNode, int> levels = new()
            {
                [root] = 1
            };

            Dictionary<int, int> levelSums = new();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                
                int level = levels[node];

                if (levelSums.ContainsKey(level))
                {
                    levelSums[level] += node.val;
                }
                else
                {
                    levelSums[level] = node.val;
                }

                if (node.left is not null)
                {
                    levels[node.left] = level + 1;
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    levels[node.right] = level + 1;
                    queue.Enqueue(node.right);
                }
            }

            int maxSum = int.MinValue;
            int result = 0;

            foreach (var item in levelSums)
            {
                if (item.Value > maxSum)
                {
                    result = item.Key;
                    maxSum = item.Value;
                }
            }

            return result;
        }
    }
}
