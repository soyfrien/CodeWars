using System.Diagnostics;

namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{ 
    [Test]
    public void NextBiggerNumber_Test()
    {//Assert.That(Kata.NextBiggerNumber(459853), Is.EqualTo(483559));
        
        Assert.That(Kata.NextBiggerNumber(12), Is.EqualTo(21));     
        Debug.WriteLine("12 -> 21");
        Assert.That(Kata.NextBiggerNumber(2017), Is.EqualTo(2071));
        Debug.WriteLine("2017 -> 2071");
        Assert.That(Kata.NextBiggerNumber(414), Is.EqualTo(441));
        Debug.WriteLine("414 -> 441");
        Assert.That(Kata.NextBiggerNumber(1), Is.EqualTo(-1));
        Debug.WriteLine("1 -> -1");
        Assert.That(Kata.NextBiggerNumber(144), Is.EqualTo(414));
        Debug.WriteLine("144 -> 414");


        Assert.That(Kata.NextBiggerNumber(1234567890), Is.EqualTo(1234567908));
        Debug.WriteLine("1234567890 -> 1234567908");
        Assert.That(Kata.NextBiggerNumber(321654456132321), Is.EqualTo(321654456133122));
        Debug.WriteLine("321654456132321 -> 321654456133122");
        Assert.That(Kata.NextBiggerNumber(221195250), Is.EqualTo(221195502));
        Debug.WriteLine("221195250 -> 221195502");

        Assert.That(Kata.NextBiggerNumber(75816995), Is.EqualTo(75819569));
        Debug.WriteLine("75816995 -> 75819569");

    }
}