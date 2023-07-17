namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{
    [Test]
    public void Factorial_Test()
    {
        Assert.That(KataHelpers.Factorial(0), Is.EqualTo(1));
        Assert.That(KataHelpers.Factorial(1), Is.EqualTo(1));
        Assert.That(KataHelpers.Factorial(2), Is.EqualTo(2));
        Assert.That(KataHelpers.Factorial(3), Is.EqualTo(6));
        Assert.That(KataHelpers.Factorial(4), Is.EqualTo(24));
        Assert.That(KataHelpers.Factorial(5), Is.EqualTo(120));
        Assert.That(KataHelpers.Factorial(6), Is.EqualTo(720));
        Assert.That(KataHelpers.Factorial(7), Is.EqualTo(5040));
        Assert.That(KataHelpers.Factorial(8), Is.EqualTo(40320));
        Assert.That(KataHelpers.Factorial(9), Is.EqualTo(362880));
        Assert.That(KataHelpers.Factorial(10), Is.EqualTo(3628800));
        Assert.That(KataHelpers.Factorial(11), Is.EqualTo(39916800));
        Assert.That(KataHelpers.Factorial(12), Is.EqualTo(479001600));
        Assert.That(KataHelpers.Factorial(13), Is.EqualTo(6227020800));
        Assert.That(KataHelpers.Factorial(14), Is.EqualTo(87178291200));
        Assert.That(KataHelpers.Factorial(15), Is.EqualTo(1307674368000));
        Assert.That(KataHelpers.Factorial(16), Is.EqualTo(20922789888000));
        Assert.That(KataHelpers.Factorial(17), Is.EqualTo(355687428096000));
        Assert.That(KataHelpers.Factorial(18), Is.EqualTo(6402373705728000));
        Assert.That(KataHelpers.Factorial(19), Is.EqualTo(121645100408832000));
        Assert.That(KataHelpers.Factorial(20), Is.EqualTo(2432902008176640000));
    }
}