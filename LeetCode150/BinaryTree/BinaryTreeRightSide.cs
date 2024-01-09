namespace LeetCode.LeetCode150.BinaryTree;

public class BinaryTreeRightSide
{
    public class Solution
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();

            int level = 0;

            if (root is null)
            {
                return result;
            }

            Queue<(TreeNode node, int level)> queue = new();

            queue.Enqueue((root, 1));

            while (queue.Count > 0)
            {
                var (node, nodeLevel) = queue.Dequeue();
                
                if (nodeLevel > level)
                {
                    result.Add(node.val);
                    level = nodeLevel;
                }

                if (node.right is not null)
                {
                    queue.Enqueue((node.right, nodeLevel + 1));
                }

                if (node.left is not null)
                {
                    queue.Enqueue((node.left, nodeLevel + 1));
                }
            }
            
            return result;
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
