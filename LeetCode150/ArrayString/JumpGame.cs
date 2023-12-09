namespace LeetCode.LeetCode150.ArrayString;

public class JumpGame
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int length = nums.Length;

            if (length == 0) 
                return false;

            bool[] visited = new bool[length];

            visited[0] = true;

            for (int i = 0; i < length; i++)
            {
                if (visited[i])
                {
                    for (int j = Math.Min(length - 1, i + nums[i]); j > i; j--)
                    {
                        visited[j] = true;
                    }
                }
            }

            return visited[length - 1];
        }
    }
}
