

namespace LeetCode.LeetCode150.BinaryTree;

public class BinaryTreeInorderPostorderTraversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            if (postorder.Length == 0)
            {
                return null;
            }

            int rootValue = postorder[^1];

            TreeNode root = new (rootValue);

            var (leftInorder, rightInorder) = SplitInorder(inorder, rootValue);

            var (leftPostorder, rightPostorder) = SplitPostorder(postorder, leftInorder);

            root.left = BuildTree(leftInorder, leftPostorder);
            root.right = BuildTree(rightInorder, rightPostorder);

            return root;
        }

        private (int[] leftPostorder, int[] leftInorder) SplitPostorder(int[] postorder, int[] leftInorder)
        {
            HashSet<int> set = new(leftInorder);

            List<int> left = new();
            List<int> right = new();

            for (int i = 0; i < postorder.Length - 1; i++)
            {
                if (set.Contains(postorder[i]))
                {
                    left.Add(postorder[i]);
                } else
                {
                    right.Add(postorder[i]);
                }
            }

            return (left.ToArray(), right.ToArray());
        }

        private (int[] leftInorder, int[] rightInorder) SplitInorder(int[] inorder, int rootValue)
        {
            List<int> left = new();
            List<int> right = new();

            bool isFound = false;

            for (int i = 0; i < inorder.Length; i++)
            {
                if (isFound)
                {
                    right.Add(inorder[i]);
                    continue;
                }

                if (inorder[i] == rootValue)
                {
                    isFound = true;
                    continue;
                }

                left.Add(inorder[i]);
            }

            return (left.ToArray(), right.ToArray());
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
