namespace LeetCode.LeetCode150.BinaryTree;

internal class CountCompleteTreeNodes
{
    public class Solution
    {
        private readonly Dictionary<TreeNode, int> leftHeights = new();
        private readonly Dictionary<TreeNode, int> rightHeights = new();

        public int CountNodes(TreeNode root)
        {
            leftHeights.Clear();
            rightHeights.Clear();

            return Count(root);
        }

        private int Count(TreeNode? node)
        {
            if (node is null)
            {
                return 0;
            }

            int leftHeight = GetLeftHeight(node);
            int rightHeight = GetRightHeight(node);

            if (leftHeight == rightHeight)
            {
                return GetCompleteTreeCount(leftHeight);
            }

            return Count(node.left) + Count(node.right) + 1;
        }

        private static int GetCompleteTreeCount(int height)
        {
            int count = 1;

            for (int i = 0; i < height; i++)
            {
                count *= 2;
            }

            return count - 1;
        }

        private int GetLeftHeight(TreeNode? node)
        {
            if (node is null)
            {
                return 0;
            }

            if (leftHeights.TryGetValue(node, out int value))
            {
                return value;
            }

            int result =  GetLeftHeight(node.left) + 1;

            leftHeights[node] = result;

            return result;
        }

        private int GetRightHeight(TreeNode? node)
        {
            if (node is null)
            {
                return 0;
            }

            if (rightHeights.TryGetValue(node, out int value))
            {
                return value;
            }

            int result = GetRightHeight(node.right) + 1;

            rightHeights[node] = result;

            return result;
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
