namespace LeetCode2026.Strings;

// 1784. Check if Binary String Has at Most One Segment of Ones
// Given a binary string s, return true if s contains at most one contiguous segment of ones. Otherwise, return false.
public class CheckOnesSegmentTask
{
    public class Solution 
    {
        // O(n) time, O(1) space
        public bool CheckOnesSegment(string s)
        {
            bool hasSeenOne = false;
            bool hasSeenZeroAfterOne = false;
            foreach (char c in s)
            {
                if (c == '1')
                {
                    if (hasSeenZeroAfterOne)
                    {
                        return false; // Found a '1' after a '0' following a '1'
                    }
                    hasSeenOne = true;
                }
                else // c == '0'
                {
                    if (hasSeenOne)
                    {
                        hasSeenZeroAfterOne = true; // Mark that we've seen a '0' after seeing a '1'
                    }
                }
            }

            return true; // No invalid pattern found
        }
    }
}