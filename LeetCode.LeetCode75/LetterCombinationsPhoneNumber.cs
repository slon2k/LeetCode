namespace LeetCode.LeetCode75;

public class LetterCombinationsPhoneNumber
{
    public class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            if (digits == "")
            {
                return new List<string>();
            }
            
            Dictionary<char, string> map = new()
            {
                { '2', "abc" }, { '3', "def" }, {'4', "ghi" },  { '5', "jkl" }, { '6', "mno" }, {'7', "pqrs" },{ '8', "tuv" }, { '9', "wxyz" },
            };

            List<string> combinations = new List<string>() { "" };

            foreach (char c in digits)
            {
                var list = new List<string>();

                foreach (string combination in combinations)
                {
                    foreach (char letter in map[c])
                    {
                        list.Add(combination + letter);
                    }

                }

                combinations = list;
            }

            return combinations;
        }
    }
}
