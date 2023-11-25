namespace LeetCode.LeetCode75;

public class SearchSuggestionsSystem
{
    public class Solution
    {
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var trie = new Trie();

            IList<IList<string>> result = new List<IList<string>>();

            foreach (var product in products)
            {
                trie.Insert(product);
            }

            string search = "";

            int count = 3;

            foreach (var letter in searchWord)
            {
                search += letter;

                result.Add(trie.FindWords(search, count));
            }

            return result;
        }

        private class Trie
        {
            private TrieNode head = new();

            public void Insert(string word)
            {
                TrieNode node = head;

                foreach (var letter in word)
                {
                    node = node.AddChildIfNotExists(letter);
                }

                node.IsEnding = true;
            }

            private TrieNode? FindNode(string prefix)
            {
                var node = head;

                foreach (var letter in prefix)
                {
                    if (node.GetChild(letter) is TrieNode child)
                    {
                        node = child;
                        continue;
                    }

                    return null;
                }

                return node;
            }

            public List<string> FindWords(string prefix, int count)
            {
                var result = new List<string>();

                Stack<(string currentPrefix, TrieNode currentNode)> stack = new();

                if (FindNode(prefix) is TrieNode node)
                {
                    stack.Push((prefix, node));
                }

                while (stack.Count > 0)
                {
                    var (currentPrefix, currentNode) = stack.Pop();

                    if (currentNode.IsEnding)
                    {
                        result.Add(currentPrefix);

                        if (result.Count >= count)
                        {
                            return result;
                        }
                    }

                    foreach ((char letter, TrieNode child) in currentNode.Children)
                    {
                        stack.Push((currentPrefix + letter, child));
                    }
                }

                return result;
            }

            private class TrieNode
            {
                private readonly Dictionary<char, TrieNode> nodes = new();

                public TrieNode? GetChild(char letter) => nodes.ContainsKey(letter) ? nodes[letter] : null;

                public List<(char, TrieNode)> Children => nodes.Select(x => (x.Key, x.Value)).OrderByDescending(x => x.Key).ToList();

                public TrieNode AddChildIfNotExists(char letter)
                {
                    if (!nodes.ContainsKey(letter))
                    {
                        nodes[letter] = new TrieNode();
                    }

                    return nodes[letter];
                }

                public bool IsEnding { get; set; } = false;
            }
        }
    }
}
