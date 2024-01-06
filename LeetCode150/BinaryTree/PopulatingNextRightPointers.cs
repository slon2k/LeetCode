namespace LeetCode.LeetCode150.BinaryTree;

public class PopulatingNextRightPointers
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            Queue<(Node node, int level)> queue = new();

            (Node node, int level) last = (new() , 0);

            if (root is not null)
            {
                queue.Enqueue((root, 1));
            }

            while (queue.Count > 0)
            {
                var (node, level) = queue.Dequeue();

                if (level == last.level)
                {
                    node.next = last.node;
                }
                else
                {
                    node.next = null;
                }

                last = (node, level);

                if (node.right is not null)
                {
                    queue.Enqueue((node.right, level + 1));
                }

                if (node.left is not null)
                {
                    queue.Enqueue((node.left, level + 1));
                }
            }

            return root;
        }
    }

    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node? next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
