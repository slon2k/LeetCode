namespace LeetCode.LeetCode150.BinaryTree;
internal class ValidateBinarySearchTree
{
    public class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            long previousValue = int.MinValue;
            previousValue--;

            foreach (var node in GetNodes(root))
            {
                if(!(node.val > previousValue))
                {
                    return false;
                }

                previousValue = node.val;
            }

            return true;
        }

        IEnumerable<TreeNode> GetNodes(TreeNode root)
        {
            if (root is not null)
            {
                foreach (var node in GetNodes(root.left))
                {
                    yield return node;
                }

                yield return root;

                foreach (var node in GetNodes(root.right))
                {
                    yield return node;
                }
            }
        }
    }
}
