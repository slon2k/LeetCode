namespace LeetCode.LeetCode75;

internal class SearchInBinarySearchTree
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
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root is null)
            {
                return null;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            
            stack.Push(root);
            
            while (stack.Count > 0)
            {

                var node = stack.Pop();
                
                if (node.val == val)
                {
                    return node;
                }

                if (node.left is not null)
                {
                    stack.Push(node.left);
                }

                if (node.right is not null)
                {
                    stack.Push(node.right);
                }
            }

            return null;
        }
    }
}
