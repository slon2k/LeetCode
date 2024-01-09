namespace LeetCode.LeetCode150.LinkedList;

internal class CopyListWithRandomPointer
{
    public class Solution
    {
        public Node? CopyRandomList(Node head)
        {
            if (head is null)
            {
                return null;
            }

            Dictionary<Node, Node> map = new();

            Node? node = head;

            while (node is not null)
            {
                map[node] = new(node.val);
                node = node.next;
            }

            node = head;

            while (node is not null)
            {
                Node copy = map[node];
                copy.next = node.next is null ? null : map[node.next];
                copy.random = node.random is null ? null : map[node.random];
                node = node.next;
            }

            return map[head];
        }
    }

    public class Node
    {
        public int val;
        public Node? next;
        public Node? random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
}
