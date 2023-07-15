using static CodeWars.Kata;

namespace CodeWars.Tests;

[TestFixture]
public partial class Tests
{
    [Test]
    public void Cogs_Test()
    {
        double expected = -4.0 / 3;

        // One gear
        Assert.That(Cogs.CogRpm(new[] { 100 }), Is.EqualTo(100));

        // Two gears
        Assert.That(Cogs.CogRpm(new[] { 100, 75 }), 
                    Is.EqualTo(expected)
                        .Within(1e-6));

        // Three gears
        expected = (-100.0 / 75) * (75.0 / -50);
        Assert.That(Cogs.CogRpm(new[] { 100, 75, 50 }),
                    Is.EqualTo(expected)
                        .Within(1e-6));

        // Four gears
        expected = (-100.0 / 75) * (75.0 / -50) * (-50.0 / 75);
        Assert.That(Cogs.CogRpm(new[] { 100, 75, 50, 75 }),
                    Is.EqualTo(expected)
                        .Within(1e-6));
        // Five gears
        expected = (-100.0 / 75) * (75.0 / -50) * (-50.0 / 75) * (75.0 / -100);
        Assert.That(Cogs.CogRpm(new[] { 100, 75, 50, 75, 100 }),
                    Is.EqualTo(expected)
                        .Within(1e-6));
    }
}