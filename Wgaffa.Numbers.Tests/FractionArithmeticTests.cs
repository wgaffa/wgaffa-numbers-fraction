using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wgaffa.Numbers.Tests
{
    [TestFixture]
    public class FractionArithmeticTests
    {
        [TestCaseSource(nameof(AddFractions))]
        public void Addition_ShouldAddFractions(Fraction left, Fraction right, Fraction expected)
        {
            var result = left + right;
            Assert.That(result, Is.EqualTo(expected));
        }

        public static object[] AddFractions = new object[]
        {
            new object[] { new Fraction(1, 8), new Fraction(4, 5), new Fraction(37, 40) },
            new object[] { new Fraction(3, 4), new Fraction(7, 8), new Fraction(13, 8) },
            new object[] { new Fraction(2, 3), new Fraction(1, 3), new Fraction(1) },
            new object[] { new Fraction(3, 4), new Fraction(1, 6), new Fraction(11, 12) },
            new object[] { new Fraction(1, 6), new Fraction(1, 3), new Fraction(1, 2) },
            new object[] { new Fraction(5, 6), new Fraction(7, 8), new Fraction(41, 24) }
        };

        [Test]
        public void Addition_ShouldAddInteger()
        {
            var fraction = new Fraction(3, 4) + 3;

            var expected = new Fraction(15, 4);

            Assert.That(expected, Is.EqualTo(expected));
        }

        static readonly List<Fraction[]> SubtractFactions = new List<Fraction[]> {
            new Fraction[] { new Fraction(5, 8), new Fraction(1, 4), new Fraction(3, 8) },
            new Fraction[] { new Fraction(2, 5), new Fraction(1, 6), new Fraction(7, 30) },
            new Fraction[] { new Fraction(3, 8), new Fraction(1, 4), new Fraction(1, 8) },
            new Fraction[] { new Fraction(2, 3), new Fraction(1, 4), new Fraction(5, 12) },
            new Fraction[] { new Fraction(5, 6), new Fraction(4, 5), new Fraction(1, 30) },
            new Fraction[] { new Fraction(3, 5), new Fraction(1, 6), new Fraction(13, 30) }
        };

        [TestCaseSource(nameof(SubtractFactions))]
        public void Subtract_ShouldSubtractTwoFractions(Fraction left, Fraction right, Fraction expected)
        {
            var result = left - right;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
