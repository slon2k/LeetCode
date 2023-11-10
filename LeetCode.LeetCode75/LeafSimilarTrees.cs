namespace LeetCode.LeetCode75;

public class LeafSimilarTrees
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
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            return SequenceEqual(GetSequence(root1), GetSequence(root2));
        }

        private List<int> GetSequence(TreeNode root)
        {
            var sequence = new List<int>();

            Traverse(root, sequence);

            return sequence;
        }

        private void Traverse(TreeNode? node, List<int> sequence)
        {
            if (node is null)
            {
                return;
            }

            if(node.left is null && node.right is null)
            {
                sequence.Add(node.val);
                return;
            }
            
            Traverse(node.left, sequence);
            Traverse(node.right, sequence);
        }

        private bool SequenceEqual(List<int> list1, List<int> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
