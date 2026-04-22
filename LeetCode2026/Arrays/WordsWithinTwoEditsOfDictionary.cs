namespace Arrays;

// 2452. Words Within Two Edits of Dictionary
// You are given two string arrays, queries and dictionary. 
// All words in each array comprise of lowercase English letters and have the same length.
// In one edit you can take a word from queries, and change any letter in it to any other letter. 
// Find all words from queries that, after a maximum of two edits, equal some word from dictionary.
// Return a list of all words from queries, that match with some word from dictionary after a maximum of two edits. 
// Return the words in the same order they appear in queries.

public class WordsWithinTwoEditsOfDictionary
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary) 
    {
        return [.. queries.Where(query => dictionary.Any(word => HasTwoEditsOrLess(query, word)))];
    }

    private static bool HasTwoEditsOrLess(string query, string word)
    {
        int edits = 0;

        for (int i = 0; i < query.Length; i++)
        {
            if (query[i] != word[i])
            {
                edits++;
            }

            if (edits > 2)
            {
                return false;
            }
        }

        return true;
    }
}