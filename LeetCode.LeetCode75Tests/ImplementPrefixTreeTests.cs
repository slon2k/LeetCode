using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class ImplementPrefixTreeTests
{
    [Theory]
    [InlineData(new string[] {}, new string[] { }, new bool[] { })]
    public void TreeSearchTest(string[] words, string[] search, bool[] expected)
    {
        var trie = new ImplementPrefixTree.Trie();

        foreach (var word in words)
        {
            trie.Insert(word);
        }

        var results = new List<bool>();

        for (var i = 0; i < search.Length; i++)
        {
            results.Add(trie.Search(search[i]));
        }

        Assert.Equal(expected, results);
    }
}
