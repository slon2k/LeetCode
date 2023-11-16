using LeetCode.LeetCode75;

namespace LeetCode.LeetCode75Tests;

public class LetterCombinationsPhoneNumberTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("23", new string[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" })]
        [InlineData("", new string[] { })]
        [InlineData("2", new string[] { "a", "b", "c" })]
        public void LetterCombinations(string digits, string[] expected)
        {
            var solution = new LetterCombinationsPhoneNumber.Solution();

            var result = solution.LetterCombinations(digits);

            Assert.Equal(expected, result);
        }
    }
}
