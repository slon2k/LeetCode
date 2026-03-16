namespace LeetCode2026.BinaryTree;

// 94. Binary Tree Inorder Traversal
// Given the root of a binary tree, return the inorder traversal of its nodes' values.  


public class BinaryTreeInorderTraversal
{
    public class Solution 
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = [];
            Traverse(root, result);
            return result;
        }

        private static void Traverse(TreeNode node, List<int> result)
        {
            if (node == null) return;

            Traverse(node.left, result);
            result.Add(node.val);
            Traverse(node.right, result);
        }
    }
}