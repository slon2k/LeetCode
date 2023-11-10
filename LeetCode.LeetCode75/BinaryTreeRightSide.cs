namespace LeetCode.LeetCode75;

public class BinaryTreeRightSide
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
        public IList<int> RightSideView(TreeNode root)
        {
            if (root is null)
            {
                return new List<int>();
            }

            Dictionary<int, int> levels = new();

            Dictionary<int, int> rightElements = new();

            Queue<TreeNode> queue = new ();

            levels[root.val] = 0;

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                int level = levels[node.val];

                rightElements[level] = node.val;

                if (node.left is not null)
                {
                    levels[node.left.val] = level + 1;
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    levels[node.right.val] = level + 1;
                    queue.Enqueue(node.right);
                }
            }

            var result = rightElements
                .OrderBy(x => x.Key)
                .Select(x => x.Value)
                .ToList();

            return result;

        }
    }
}
