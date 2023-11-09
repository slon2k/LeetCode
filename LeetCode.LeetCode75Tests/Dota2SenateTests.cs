using LeetCode.LeetCode75;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode.LeetCode75Tests;

public class Dota2SenateTests
{
    [Theory]
    [InlineData("RDD", "Dire")]
    [InlineData("RD", "Radiant")]
    public void PredictPartyVictoryTest(string senate, string expected)
    {
        var solution = new Dota2Senate.Solution();

        var result = solution.PredictPartyVictory(senate);

        Assert.Equal(expected, result);
    }
}
