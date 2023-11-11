namespace LeetCode.LeetCode75;

internal class DeleteNodeBST
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
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root is null)
            {
                return root;
            }

            if (root.val == key)
            {
                return DeleteNode(root);
            }

            if (root.val > key)
            {
                root.left = DeleteNode(root.left, key);
            }

            if (root.val < key)
            {
                root.right = DeleteNode(root.right, key);
            }

            return root;
        }

        private TreeNode? DeleteNode(TreeNode? node)
        {
            if (node is null)
            {
                return null;
            }

            if (node.left is null)
            {
                return node.right;
            }

            if (node.right is null)
            {
                return node.left;
            }

            int max = FindMax(node.left);

            node.val = max;

            node.left = DeleteNode(node.left, max);

            return node;
        }

        private int FindMax(TreeNode root)
        {
            var node = root;

            while (node.right is not null)
            {
                node = node.right;
            }

            return node.val;
        }

        private int FindMin(TreeNode root)
        {
            var node = root;

            while (node.left is not null)
            { 
                node = node.left; 
            }

            return node.val;
        }
    }
}
