namespace LeetCode.LeetCode150.BinaryTree;

internal class BinaryTreeZigzagLevelOrderTraversal
{
    public class Solution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (root is null)
            {
                return result;
            }

            int currentLevel = 0;
            
            Queue<(TreeNode, int)> queue = new();

            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var (node, level) = queue.Dequeue();

                if (level > currentLevel)
                {
                    currentLevel = level;
                    result.Add(new List<int>());
                }

                result[^1].Add(node.val);

                if (node.left is not null)
                {
                    queue.Enqueue((node.left, level + 1));
                }

                if (node.right is not null)
                {
                    queue.Enqueue((node.right, level + 1));
                }
            }

            return result.Select((level, index) => index % 2 == 0 ? level : level.Reverse().ToList()).ToList();
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
