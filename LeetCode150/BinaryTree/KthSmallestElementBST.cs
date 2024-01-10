namespace LeetCode.LeetCode150.BinaryTree;

public class KthSmallestElementBST
{
    public class Solution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            return GetNodes(root).Skip(k - 1).First().val;
        }

        public static IEnumerable<TreeNode> GetNodes(TreeNode root)
        {
            if (root is not null)
            {
                if (root.left is not null)
                {
                    foreach (var node in GetNodes(root.left))
                    {
                        yield return node;
                    }
                }

                yield return root;

                if (root.right is not null)
                {
                    foreach (var node in GetNodes(root.right))
                    {
                        yield return node;
                    }
                }

            }
        }
    }
}
