namespace LeetCode.LeetCode75;

public class ImplementPrefixTree
{
    public class Trie
    {
        private readonly TrieNode head;

        public Trie()
        {
            head = new TrieNode();
        }

        public void Insert(string word)
        {
            var node = head;

            for (int i = 0; i < word.Length; i++)
            {
                node = node.TryAddChild(word[i]);
            }

            node.SetEnding(true);
        }

        public bool Search(string word)
        {
            TrieNode? node = head;

            foreach (var c in word)
            {
                node = node?.GetChild(c);

                if (node is null)
                {
                    return false;
                }
            }

            if (node.IsWordEnding)
            {
                return true;
            }

            return false;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode? node = head;

            foreach (var c in prefix)
            {
                node = node?.GetChild(c);

                if (node is null)
                {
                    return false;
                }
            }

            return true;
        }

        private class TrieNode
        {
            private bool isWordEnding;

            private readonly Dictionary<char, TrieNode> children = new();

            public TrieNode(bool isWordEnding = false)
            {
                this.isWordEnding = isWordEnding;
            }

            public TrieNode? GetChild(char c) => children.ContainsKey(c) ? children[c] : null;

            public TrieNode TryAddChild(char c)
            {
                if (!children.ContainsKey(c))
                {
                    children[c] = new TrieNode();
                }

                return children[c];
            }

            public bool IsWordEnding => isWordEnding;

            public void SetEnding(bool isWordEnding) => this.isWordEnding = isWordEnding;
        }
    }
}
