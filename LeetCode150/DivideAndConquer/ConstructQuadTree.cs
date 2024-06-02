namespace LeetCode.LeetCode150.DivideAndConquer;

public class ConstructQuadTree
{

    // Definition for a QuadTree node.
    public class Node {
        public bool val;
        public bool isLeaf;
        public Node topLeft;
        public Node topRight;
        public Node bottomLeft;
        public Node bottomRight;

        public Node() {
            val = false;
            isLeaf = false;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }
    
        public Node(bool _val, bool _isLeaf) {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = null;
            topRight = null;
            bottomLeft = null;
            bottomRight = null;
        }
    
        public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
            val = _val;
            isLeaf = _isLeaf;
            topLeft = _topLeft;
            topRight = _topRight;
            bottomLeft = _bottomLeft;
            bottomRight = _bottomRight;
        }
    }

    public class Solution
    {
        public Node Construct(int[][] grid)
        {
            int size = grid[0].Length;

            return CreateNode(grid, 0, 0, size);
        }

        private Node CreateNode(int[][] grid, int x, int y, int size)
        {
            if (IsLeaf(grid, x, y, size))
            {
                int value = grid[x][y];
                return new Node(value == 1, true);
            }

            size /= 2;

            Node topLeft = CreateNode(grid, x, y, size);
            Node topRight = CreateNode(grid, x, y + size, size);
            Node bottomLeft = CreateNode(grid, x + size, y, size);
            Node bottomRight = CreateNode(grid, x + size, y + size, size);

            return new Node(true, false, topLeft, topRight, bottomLeft, bottomRight);
        }

        private static bool IsLeaf(int[][] grid, int x, int y, int size)
        {
            int value = grid[x][y];
            
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (grid[x + i][y + j] != value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
