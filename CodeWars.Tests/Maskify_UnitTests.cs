namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{
    [Test]
    public void Maskify_Test()
    {
        Assert.That(Kata.Maskify("4556364607935616"), Is.EqualTo("############5616"));
        Assert.That(Kata.Maskify("1"), Is.EqualTo("1"));
        Assert.That(Kata.Maskify("11111"), Is.EqualTo("#1111"));
        Assert.That(Kata.Maskify("Skippy"), Is.EqualTo("##ippy"));
        Assert.That(Kata.Maskify(""), Is.EqualTo(""));
        Assert.That(Kata.Maskify(string.Empty), Is.EqualTo(string.Empty));

    }
}
