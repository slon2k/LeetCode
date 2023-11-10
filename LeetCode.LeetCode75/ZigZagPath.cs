namespace LeetCode.LeetCode75;

public class ZigZagPath
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        private int maxLength = 0;

        public int LongestZigZag(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            int currentPathLength = 0;

            Traverse(root.left, "left", currentPathLength);
            Traverse(root.right, "right", currentPathLength);

            return maxLength;
        }

        private void Traverse(TreeNode node, string direction, int currentPathLength)
        {
            if (node is null)
            {
                return;
            }

            currentPathLength++;

            if (currentPathLength > maxLength)
            {
                maxLength = currentPathLength;
            }

            Traverse(node.left, "left", direction == "left" ? 0: currentPathLength);
            Traverse(node.right, "right", direction == "right" ? 0 : currentPathLength);
        }
    }
}
