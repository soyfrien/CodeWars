using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestFixture]
    public partial class Tests
    {
        [Test]
        public void OpenOrSenior_Test()
        {
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
        }

        [Test]
        public void OpenOrSeniorLinq_Test()
        {
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
        }

        [Test]
        public void OpenOrSeniorFavorite_Test()
        {
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
        }

        [Test]
        public void OpenOrSeniorAlt_Test()
        {
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }), Is.EqualTo(new[] { "Open", "Senior", "Open", "Senior" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }), Is.EqualTo(new[] { "Open", "Open", "Open", "Open" }));
            Assert.That(Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }), Is.EqualTo(new[] { "Senior", "Open", "Open", "Open" }));
        }
    }
}