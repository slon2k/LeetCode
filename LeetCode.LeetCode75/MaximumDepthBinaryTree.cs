namespace LeetCode.LeetCode75;

public class MaximumDepthBinaryTree
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
        public int MaxDepth(TreeNode root)
        {
            return GetDepth(root);
        }

        private int GetDepth(TreeNode node)
        {
            if (node is null) 
                return 0;

            return Math.Max(GetDepth(node.left), GetDepth(node.right)) + 1;

        }
    }
}
