using LeetCode.LeetCode150.ArrayString;

namespace LeetCode.LeetCode150Tests.ArrayString;

public class TextJustificationTests
{
    [Theory]
    [InlineData(
        new string[] { "This", "is", "an", "example", "of", "text", "justification." },
        16,
        new string[] 
        {
            "This    is    an",
            "example  of text",
            "justification.  "
        })]
    [InlineData(
        new string[] { "What","must","be","acknowledgment","shall","be" },
        16,
        new string[] 
        { 
            "What   must   be",
            "acknowledgment  ",
            "shall be        "}
        )]
    [InlineData(
        new string[]{ "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" },
        20,
        new string[] 
        { 
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  "
        })]
    public void FullJustifyTest(string[] words, int maxWidth, string[] expected)
    {
        var solution = new TextJustification.Solution();

        var result = solution.FullJustify(words, maxWidth);

        Assert.Equal(expected, result);
    }
}

