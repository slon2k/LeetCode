namespace LeetCode.LeetCode75;

public class LowestCommonAncestor
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
        private int node1 = 0;
        private int node2 = 0;

        private List<TreeNode> ancestors1 = new();
        private List<TreeNode> ancestors2 = new();

        private Dictionary<TreeNode, TreeNode?> parentNode = new();

        public TreeNode? LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Stack<TreeNode> stack = new();

            stack.Push(root);

            parentNode.Clear();

            parentNode[root] = null;

            while (stack.Count > 0)
            {
                var node = stack.Pop();

                if (node.left is not null)
                {
                    parentNode[node.left] = node;
                    stack.Push(node.left);
                }

                if (node.right is not null)
                {
                    parentNode[node.right] = node;
                    stack.Push(node.right);
                }
            }

            ancestors1.Clear();
            ancestors2.Clear();

            ancestors1.AddRange(GetAncestors(p));
            ancestors2.AddRange(GetAncestors(q));

            foreach (var node in ancestors1)
            {
                if (ancestors2.Any(x => x.val == node.val))
                {
                    return node;
                }
            }

            return null;
        }

        private List<TreeNode> GetAncestors(TreeNode node)
        {
            var list = new List<TreeNode>();

            TreeNode? prev = node;

            while (prev != null)
            {
                list.Add(prev);
                prev = parentNode.GetValueOrDefault(prev);
            }

            return list;
        }

        public TreeNode? LowestCommonAncestorRecursive(TreeNode root, TreeNode p, TreeNode q)
        {
            node1 = p.val;
            node2 = q.val;

            ancestors1.Clear();
            ancestors2.Clear();

            Traverse(root, new List<TreeNode>());

            TreeNode? commonAncestor = null;

            foreach (var node in ancestors1)
            {
                if (ancestors2.Any(x => x.val == node.val))
                {
                    commonAncestor = node;
                }
            }

            return commonAncestor;
        }

        private void Traverse(TreeNode node, List<TreeNode> path)
        {
            if (node is null) 
            {
                return;
            };

            var currentPath = new List<TreeNode>(path)
            {
                node
            };

            if (node.val == node1)
            {
                ancestors1.Clear();
                ancestors1.AddRange(currentPath);
            }

            if (node.val == node2)
            {
                ancestors2.Clear();
                ancestors2.AddRange(currentPath);
            }

            if (node.left is not null)
            {
                Traverse(node.left, currentPath);
            }

            if (node.right is not null)
            {
                Traverse(node.right, currentPath);
            }
        }
    }
}
