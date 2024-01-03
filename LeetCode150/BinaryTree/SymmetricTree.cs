namespace LeetCode.LeetCode150.BinaryTree;

internal class SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root is null)
                return true;

            if (root.left is null)
                return root.right is null;

            if (root.right is null)
                return root.left is null;

            return AreEqual(root.left, InvertTree(root.right));
        }

        private static TreeNode InvertTree(TreeNode root)
        {
            if (root is null)
            {
                return root;
            }

            var left = InvertTree(root.left);
            var right = InvertTree(root.right);

            root.left = right;
            root.right = left;

            return root;
        }

        private static bool AreEqual(TreeNode node1, TreeNode node2)
        {
            if (node1 is null)
                return node2 is null;

            if (node2 is null)
                return node1 is null;

            if (node1.val != node2.val)
                return false;

            return AreEqual(node1.left, node2.left) && AreEqual(node1.right, node2.right);
        }
    }

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
}
