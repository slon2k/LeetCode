namespace LeetCode.LeetCode150.BinaryTree;

public class BSTIterator
{
    private readonly Stack<TreeNode> stack = new();

    public BSTIterator(TreeNode root)
    {
        stack.Clear();

        if (root is not null)
        {
            stack.Push(root);
        }
    }

    public int Next()
    {
        TreeNode node = stack.Pop();

        if (node.right is not null)
        {
            stack.Push(node.right);
        }

        if (node.left is not null)
        {
            stack.Push(node.left);
        }

        return node.val;
    }

    public bool HasNext()
    {
        return stack.Count > 0;
    }
}