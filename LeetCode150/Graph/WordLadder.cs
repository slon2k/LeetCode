namespace LeetCode.LeetCode150.Graph;

internal class WordLadder
{
    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            HashSet<string> words = new(wordList);

            Queue<(string, int)> queue = new();

            queue.Enqueue((beginWord, 1));
            words.Remove(beginWord);

            while (queue.Count > 0)
            {
                var (word, count) = queue.Dequeue();

                if (word == endWord)
                {
                    return count;
                }

                foreach (var neighbor in GetNeighbors(word, words))
                {
                    queue.Enqueue((neighbor, count + 1));
                    words.Remove(neighbor);
                }
            }

            return 0;
        }

        private IEnumerable<string> GetNeighbors(string word, HashSet<string> words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    var neighbor = word[..i] + c + word[(i + 1)..];

                    if (neighbor != word && words.Contains(neighbor))
                    {
                        yield return neighbor;
                    }
                }
            }
        }
    }
}
