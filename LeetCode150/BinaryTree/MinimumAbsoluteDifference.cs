namespace LeetCode.LeetCode150.BinaryTree;

public class MinimumAbsoluteDifference
{
    public class Solution
    {
        public int GetMinimumDifference(TreeNode root)
        {
            long previousValue = int.MinValue;

            long result = int.MaxValue;

            foreach (var node in GetTreeNodes(root))
            {
                result = Math.Min(result, node.val - previousValue);
                previousValue = node.val;
            }

            return (int)result;
        }

        public IEnumerable<TreeNode> GetTreeNodes(TreeNode root)
        {
            if (root is not null)
            {
                if (root.left is not null)
                {
                    foreach (var node in GetTreeNodes(root.left))
                    {
                        yield return node;
                    }
                }

                yield return root;

                if (root.right is not null)
                {
                    foreach (var node in GetTreeNodes(root.right))
                    {
                        yield return node;
                    }
                }
            }
        }
    }
}
