namespace LeetCode.LeetCode150.BinaryTree;

public class SumRootLeafNumbers
{
    public class Solution
    {
        public int SumNumbers(TreeNode root)
        {
            Stack<(TreeNode node, int sum)> stack = new ();

            int total = 0;

            if (root is not null)
            {
                stack.Push((root, 0));
            }

            while (stack.Count > 0)
            {
                var (node, sum) = stack.Pop();

                sum = sum * 10 + node.val;

                if (IsLeaf(node))
                {
                    total += sum;
                }

                if (node.right is not null)
                {
                    stack.Push((node.right, sum));
                }

                if (node.left is not null)
                {
                    stack.Push((node.left, sum));
                }
            }

            return total;
        }

        private static bool IsLeaf(TreeNode node) => node.left is null && node.right is null;
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
