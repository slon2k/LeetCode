namespace LeetCode.LeetCode150.BinaryTree;

public class BinaryTreeFromPreorderInorderTraversal
{
    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return Build(preorder, inorder);
        }

        private TreeNode? Build(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
               return null;

            int rootValue = preorder[0];

            var root = new TreeNode(rootValue);

            var (inorderLeft, inorderRight) = SplitInorder(inorder, rootValue);
            var (preorderLeft, preorderRight) = SplitPreorder(preorder, inorderLeft);

            root.left = Build(preorderLeft, inorderLeft);
            root.right = Build(preorderRight, inorderRight);

            return root;
        }

        private (int[] left, int[] right) SplitPreorder(int[] array, int[] inorderLeft)
        {
            List<int> left = new();
            List<int> right = new();

            HashSet<int> set = new(inorderLeft);

            bool isRight = false;

            for (int i = 1; i < array.Length; i++)
            {
                if (isRight)
                {
                    right.Add(array[i]);
                    continue;
                }

                if (!set.Contains(array[i]))
                {
                    isRight = true;
                    right.Add(array[i]);
                    continue;
                }

                left.Add(array[i]);
            }

            return (left.ToArray(), right.ToArray());
        }

        private (int[] left, int[] right) SplitInorder(int[] array, int value)
        {
            List<int> left = new();
            List<int> right = new();

            bool isFound = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    isFound = true;
                    continue;
                }

                if (isFound)
                {
                    right.Add(array[i]);
                } else
                {
                    left.Add(array[i]);
                }
            }

            return (left.ToArray(), right.ToArray());
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
}
