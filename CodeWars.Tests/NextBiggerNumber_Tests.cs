namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{ 
    [Test]
    public void NextBiggerNumber_Test()
    {
        Assert.That(Kata.NextBiggerNumber(12), Is.EqualTo(21));
        Assert.That(Kata.NextBiggerNumber(2017), Is.EqualTo(2071));
        Assert.That(Kata.NextBiggerNumber(414), Is.EqualTo(441));
        Assert.That(Kata.NextBiggerNumber(1), Is.EqualTo(-1));
        Assert.That(Kata.NextBiggerNumber(144), Is.EqualTo(414));

        Assert.That(Kata.NextBiggerNumber(1234567890), Is.EqualTo(1234567908));

        Assert.That(Kata.NextBiggerNumber(321654456132321), Is.EqualTo(321654456133122));
        Assert.That(Kata.NextBiggerNumber(221195250), Is.EqualTo(221195502));
    }
}

/// 321654456132321
/// 321654456133122
/// 321654456133221