namespace LeetCode2026.Strings;

// 1980. Find Unique Binary String
// Given an array of strings nums containing n unique binary strings each of length n, return a binary string of length n that does not appear in nums. If there are multiple answers, you may return any of them.  

public class FindUniqueBinaryString
{
    public class Solution 
    {
        public string FindDifferentBinaryString(string[] nums)
        {
            int n = nums.Length;
            var set = new HashSet<string>(nums);

            for (int i = 0; i < (1 << n); i++)
            {
                var binaryString = Convert.ToString(i, 2).PadLeft(n, '0');

                if (!set.Contains(binaryString))
                {
                    return binaryString;
                }
            }

            return string.Empty;
        }
    }
}