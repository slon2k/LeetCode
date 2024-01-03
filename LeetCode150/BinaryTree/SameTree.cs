namespace LeetCode.LeetCode150.BinaryTree;

internal class SameTree
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
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return AreEqual(p, q);
        }

        bool AreEqual(TreeNode? node1, TreeNode? node2)
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
}
