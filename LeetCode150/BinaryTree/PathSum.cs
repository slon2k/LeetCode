namespace LeetCode.LeetCode150.BinaryTree;

internal class PathSum
{
    public class Solution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null)
                return false;

            Stack <(int sum, TreeNode node)> stack = new();
            stack.Push((0, root));

            while (stack.Count > 0)
            {
                var (sum, node) = stack.Pop();
                sum += node.val;

                if (IsLeaf(node) && sum == targetSum)
                {
                    return true;
                }

                if (node.left is not null)
                {
                    stack.Push((sum, node.left));
                }

                if (node.right is not null)
                {
                    stack.Push((sum, node.right));
                }
            }

            return false;
        }

        private static bool IsLeaf(TreeNode node) => node != null && node.left is null && node.right is null;
        
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
}
