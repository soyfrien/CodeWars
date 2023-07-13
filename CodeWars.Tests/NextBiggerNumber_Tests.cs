namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{ 
    [Test]
    public void NextBiggerNumber_Test()
    {
        Assert.That(Kata.NextBiggerNumber(12), Is.EqualTo(21));
        Assert.That(Kata.NextBiggerNumber(513), Is.EqualTo(531));
        Assert.That(Kata.NextBiggerNumber(2017), Is.EqualTo(2071));
        Assert.That(Kata.NextBiggerNumber(414), Is.EqualTo(441));
        Assert.That(Kata.NextBiggerNumber(144), Is.EqualTo(414));
        Assert.That(Kata.NextBiggerNumber(1), Is.EqualTo(-1));
    }
}