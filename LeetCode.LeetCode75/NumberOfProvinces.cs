namespace LeetCode.LeetCode75;

public class NumberOfProvinces
{
    public class Solution
    {
        public int FindCircleNum(int[][] isConnected)
        {
            int length = isConnected.Length;

            int[] visited = new int[length]; 
            
            int province = 0;

            for (int i = 0; i < length; i++)
            {
                if (visited[i] == 0)
                {
                    province++;
                    Traverse(isConnected, i, visited, province);
                }              
            }

            return province;
        }

        private void Traverse(int[][] isConnected, int start, int[] visited, int province)
        {
            Stack<int> stack = new();

            stack.Push(start);

            while (stack.Count > 0)
            {
                int i = stack.Pop();

                if (visited[i] == 0)
                {
                    visited[i] = province;

                    for(int j = 1; j < isConnected[i].Length; j++)
                    {
                        if (isConnected[i][j] == 1 && visited[j] == 0)
                        {
                            stack.Push(j);
                        }
                    }
                }
            }
        }
    }
}
