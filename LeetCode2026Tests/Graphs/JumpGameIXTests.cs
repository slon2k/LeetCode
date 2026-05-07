using LeetCode2026.Graphs;

namespace LeetCode2026Tests.Graphs;

public class JumpGameIXTests
{
    [Fact]
    public void MaxValue_ReturnsExpectedValues_ForFirstExample()
    {
        var sut = new JumpGameIX();

        var actual = sut.MaxValue([2, 1, 3]);

        Assert.Equal([2, 2, 3], actual);
    }

    [Fact]
    public void MaxValue_ReturnsExpectedValues_ForSecondExample()
    {
        var sut = new JumpGameIX();

        var actual = sut.MaxValue([2, 3, 1]);

        Assert.Equal([3, 3, 3], actual);
    }

    [Fact]
    public void MaxValue_TreatsEqualValuesAsSeparateComponents_WhenNoStrictInversionExists()
    {
        var sut = new JumpGameIX();

        var actual = sut.MaxValue([1, 1, 2, 2]);

        Assert.Equal([1, 1, 2, 2], actual);
    }
}