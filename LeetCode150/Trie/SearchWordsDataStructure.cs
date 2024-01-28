namespace LeetCode.LeetCode150.Trie;

public class SearchWordsDataStructure
{
    public class WordDictionary
    {
        private readonly TrieNode head = new();

        public WordDictionary()
        {

        }

        public void AddWord(string word)
        {
            TrieNode node = head;

            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                node.TryAddLetter(letter);
                node = node.Children[letter];
            }

            node.IsEnding = true;
        }

        public bool Search(string word)
        {
            return head.Search(word);
        }

        private class TrieNode
        {
            public bool IsEnding { get; set; }
            
            public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();

            public void TryAddLetter(char letter)
            {
                if (!Children.ContainsKey(letter))
                {
                    Children.Add(letter, new TrieNode());
                }
            }

            public bool Search(string word)
            {
                if (word.Length == 0)
                {
                    return IsEnding;
                }

                char letter = word[0];
                
                string next = word[1..];
                
                if (letter == '.')
                {
                    foreach (var node in Children.Values)
                    {
                        if (node.Search(next))
                        {
                            return true;
                        }
                    }

                    return false;
                }

                if (Children.TryGetValue(letter, out TrieNode? value)) 
                { 
                    return value.Search(next);
                }

                return false;
            }
        }
    }
}
