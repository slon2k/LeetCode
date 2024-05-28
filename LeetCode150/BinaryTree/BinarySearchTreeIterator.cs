namespace LeetCode.LeetCode150.BinaryTree;

public class BSTIterator
{
    private readonly TreeNode root;

    private readonly BSTIterator? leftIterator;
    private readonly BSTIterator? rightIterator;

    private bool visited = false;

    public BSTIterator(TreeNode root)
    {
        this.root = root;

        if (root is not null)
        {
            leftIterator = root.left is not null ? new BSTIterator(root.left) : null;
            rightIterator = root.right is not null ? new BSTIterator(root.right) : null;
        }  
    }

    public int Next()
    {
        if ((leftIterator is not null) && leftIterator.HasNext())
        {
            return leftIterator.Next();
        }

        if (!visited)
        {
            visited = true;
            return root.val;
        }

        if ((rightIterator is not null) && rightIterator.HasNext())
        {
            return rightIterator.Next();
        }

        throw new InvalidOperationException("According to the task, we assume that next is always valid");
    }

    public bool HasNext()
    {
        if (root is null)
        {
            return false;
        }

        if (!visited)
        {
            return true;
        }

        if ((leftIterator is not null) && leftIterator.HasNext())
        {
            return true;
        }

        if ((rightIterator is not null) && rightIterator.HasNext())
        {
            return true;
        }

        return false;
    }
}