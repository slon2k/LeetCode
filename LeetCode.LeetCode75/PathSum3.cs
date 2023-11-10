namespace LeetCode.LeetCode75;

public class PathSum3
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
        private int count = 0;
        
        public int PathSum(TreeNode root, int targetSum)
        {
            count = 0;

            Traverse(root, targetSum, new List<int>());

            return count;
        }

        private void Traverse(TreeNode node, int targetSum, List<int> path)
        {
            if (node is null)
            {
                return;
            } 

            var newPath = new List<int>(path)
            {
                node.val
            };

            count += CountTargetPaths(newPath, targetSum);

            Traverse(node.left, targetSum, newPath);
            Traverse(node.right, targetSum, newPath);

        }

        private static int CountTargetPaths(List<int> path, int targetSum)
        {
            long sum = 0;
            int count = 0;

            for (int i = path.Count - 1; i >= 0; i--)
            {
                sum += path[i];

                if (sum == targetSum)
                {
                    count++;
                }
            }

            return count;
        }

    }
}
