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

            var preorderLeft = preorder.Where(x => IsAhead(x, rootValue, inorder)).ToArray() ?? Array.Empty<int>();
            var preorderRight = preorder.Where(x => IsBehind(x, rootValue, inorder)).ToArray() ?? Array.Empty<int>();

            var inorderLeft = inorder.Where(x => IsAhead(x, rootValue, inorder)).ToArray() ?? Array.Empty<int>();
            var inorderRight = inorder.Where(x => IsBehind(x, rootValue, inorder)).ToArray() ?? Array.Empty<int>();

            root.left = Build(preorderLeft, inorderLeft);
            root.right = Build(preorderRight, inorderRight);

            return root;
        }

        private (int[] left, int[] right) Split(int[] array, int value)
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

        private bool IsAhead(int num1, int num2, int[] array) => Array.IndexOf(array, num1) < Array.IndexOf(array, num2);

        private bool IsBehind(int num1, int num2, int[] array) => Array.IndexOf(array, num1) > Array.IndexOf(array, num2);

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
