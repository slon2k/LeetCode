namespace LeetCode.LeetCode150.BinaryTree;

public class FlattenBinaryTree
{
    public class Solution
    {
        public void Flatten(TreeNode root)
        {
            Stack<TreeNode> stack = new();

            TreeNode head = new();

            TreeNode tail = head;

            if (root is not null)
            {
                stack.Push(root);
            }

            while(stack.Count > 0)
            {
                var node = stack.Pop();

                if (node.right is not null)
                {
                    stack.Push(node.right);
                }

                if (node.left is not null)
                {
                    stack.Push(node.left);
                }

                tail.right = node;
                tail = tail.right;
                tail.left = null;
                tail.right = null;
            }
        }
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
