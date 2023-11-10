namespace LeetCode.LeetCode75;

public class CountGoodNodesBinaryTree
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
        private int count = 0;
        
        public int GoodNodes(TreeNode root)
        {
            count = 0;

            Traverse(root, int.MinValue);

            return count;
        }

        private void Traverse(TreeNode node, int maximum)
        {
            if (node == null)
                return;

            if (node.val >= maximum) 
            {
                count++;
                maximum = node.val;
            }

            Traverse(node.left, maximum);
            Traverse(node.right, maximum);
        }
    }
}
