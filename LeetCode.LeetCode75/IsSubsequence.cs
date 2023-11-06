namespace LeetCode.LeetCode75;

public class IsSubsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            answers.Clear();
            
            return HasSubsequense(s, t);
        }

        private readonly Dictionary<(string, string), bool> answers = new();

        private bool HasSubsequense(string s, string t)
        {
            string t1 = new(t.Where(s.Contains).ToArray());

            if (answers.ContainsKey((s, t1)))
            {
                return answers[(s, t1)];
            }

            if (s.Length > t1.Length)
            {
                answers[(s, t1)] = false;
                answers[(s, t)] = false;
                return false;
            }

            if (t1.Contains(s))
            {
                answers[(s, t1)] = true;
                answers[(s, t)] = true;
                return true;
            }

            int n = t1.Length / 2;

            string leftT = t1.Substring(0, n);

            string rightT = t1.Substring(n);

            for (int i = 0; i < s.Length; i++)
            {
                string leftS = s.Substring(0, i);
                string rightS = s.Substring(i);
                
                if (HasSubsequense(leftS, leftT) && HasSubsequense(rightS, rightT))
                {
                    answers[(s, t1)] = true;
                    answers[(s, t)] = true;
                    return true;
                }
            }

            answers[(s, t1)] = false;
            answers[(s, t)] = false;

            return false;
        }
    }
}
