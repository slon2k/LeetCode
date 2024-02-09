namespace LeetCode.LeetCode150.DP;

public class InterleavingString
{
    public class Solution
    {
        private readonly Dictionary<(string, string, string), bool> results = new();

        public bool IsInterleave(string s1, string s2, string s3)
        {
            return IsInterleaving(s1, s2, s3);
        }

        private bool IsInterleaving(string s1, string s2, string s3)
        {
            if (results.ContainsKey((s1, s2, s3)))
            {
                return results[(s1, s2, s3)];
            }

            if (s3.Length != s1.Length + s2.Length)
            {
                return false;
            }

            if (s1 == "")
            {
                return s2 == s3;
            }

            if (s2 == "")
            {
                return s1 == s3;
            }

            if (s1[0] != s3[0] && s2[0] != s3[0])
            {
                return false;
            }

            if (s1[0] == s3[0] && s2[0] != s3[0])
            {
                results[(s1, s2, s3)] = IsInterleaving(s1[1..], s2, s3[1..]);
                return results[(s1, s2, s3)];
            }

            if (s2[0] == s3[0] && s1[0] != s3[0])
            {
                results[(s1, s2, s3)] = IsInterleaving(s1, s2[1..], s3[1..]);
                return results[(s1, s2, s3)];
            }

            if (IsInterleaving(s1[1..], s2, s3[1..]))
            {
                results[(s1, s2, s3)] = true;
                return results[(s1, s2, s3)];
            }

            if (IsInterleaving(s1, s2[1..], s3[1..]))
            {
                results[(s1, s2, s3)] = true;
                return results[(s1, s2, s3)];
            }

            return false;
        }
    }
}
