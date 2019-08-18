using NUnit.Framework;
using System.Collections.Generic;

namespace Wgaffa.Numbers.Tests
{
    [TestFixture]
    public class FractionCompareTests
    {
        static readonly List<object[]> CompareFractionsData = new List<object[]> {
            new object[] { new Fraction(4, 8), new Fraction(10, 8), -1 },
            new object[] { new Fraction(4, 5), new Fraction(2, 5), 1 },
            new object[] { new Fraction(2, 3), new Fraction(2, 4), 1 },
            new object[] { new Fraction(2, 5), new Fraction(7, 3), -1 },
            new object[] { new Fraction(12, 5), new Fraction(1, 4), 1 },
            new object[] { new Fraction(12, 8), new Fraction(6, 4), 0 }
        };

        [TestCaseSource(nameof(CompareFractionsData))]
        public void CompareTo_ShouldCompareTwoFractions(Fraction left, Fraction right, int expected)
        {
            Assert.That(left.CompareTo(right), Is.EqualTo(expected));
        }
    }
}
