namespace LeetCode2026.BinaryTree;

// 110. Balanced Binary Tree
// Given a binary tree, determine if it is height-balanced.

public class BalancedBinaryTree
{
    public class Solution 
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;
            if (!IsBalanced(root.left)) return false;
            if (!IsBalanced(root.right)) return false;
            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);
            return Math.Abs(leftHeight - rightHeight) <= 1;
        }

        private static int GetHeight(TreeNode node)
        {
            if (node == null) return 0;
            int leftHeight = GetHeight(node.left);
            int rightHeight = GetHeight(node.right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
