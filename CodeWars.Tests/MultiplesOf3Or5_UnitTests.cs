namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{
    [Test]
    public void MultiplesOf3Or5_Test()
    {
        Assert.That(Kata.Solution(-10), Is.EqualTo(0));
    }
}