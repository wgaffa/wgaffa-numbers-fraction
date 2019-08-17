using NUnit.Framework;
using System;
using System.Collections;

namespace Wgaffa.Numbers.Tests
{
    [TestFixture]
    public class FractionTests
    {
        [Test]
        public void FractionCtor_ShouldThrowArgumentException_GivenDenominator0()
        {
            Assert.That(() => new Fraction(5, 0), Throws.ArgumentException);
        }

        [TestCase(3, 5, ExpectedResult = 1)]
        [TestCase(-7, 49, ExpectedResult = -1)]
        [TestCase(6, -34, ExpectedResult = -1)]
        [TestCase(-34, -5, ExpectedResult = 1)]
        public int Sign_ShouldReturnCorrectSign(int numerator, int denominator)
        {
            var fraction = new Fraction(numerator, denominator);

            return fraction.Sign;
        }

        [TestCaseSource(typeof(EqualFractions))]
        public void FractionEquals_ShouldExpectEquality(Fraction left, Fraction right, bool expected)
        {
            Assert.That(left.Equals(right), Is.EqualTo(expected));
        }

        [TestCaseSource(typeof(SingleFractionCases))]
        public void Numerator_ShouldBeSimplified(Fraction fraction, int[] expected)
        {
            Assert.That(fraction.Numerator, Is.EqualTo(expected[0]));
        }

        [TestCaseSource(typeof(SingleFractionCases))]
        public void Denominator_ShouldBeSimplified(Fraction fraction, int[] expected)
        {
            Assert.That(fraction.Denominator, Is.EqualTo(expected[1]));
        }

        [TestCaseSource(typeof(SingleFractionCases))]
        public void CastToInt_ShouldCast(Fraction fraction, int[] expected)
        {
            Assert.That((int)fraction, Is.EqualTo(expected[2]));
        }

        [TestCaseSource(typeof(SingleFractionCases))]
        public void ProperNumerator_ShouldReturnExpected(Fraction fraction, int[] expected)
        {
            Assert.That(fraction.ProperNumerator, Is.EqualTo(expected[3]));
        }
    }

    class SingleFractionCases : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Fraction(2, 5), new int[] { 2, 5, 0, 2 } };
            yield return new object[] { new Fraction(7, 18), new int[] { 7, 18, 0, 7 } };
            yield return new object[] { new Fraction(2, 8), new int[] { 1, 4, 0 , 1} };
            yield return new object[] { new Fraction(9, 10), new int[] { 9, 10, 0, 9 } };
            yield return new object[] { new Fraction(8, 100), new int[] { 2, 25, 0, 2 } };
            yield return new object[] { new Fraction(5, 1), new int[] { 5, 1, 5, 0 } };
            yield return new object[] { new Fraction(87, 12), new int[] { 29, 4, 7, 1 } };
        }
    }

    class EqualFractions : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new Fraction(2, 5), new Fraction(4, 10), true };
            yield return new object[] { new Fraction(1, 2), new Fraction(50, 100), true };
            yield return new object[] { new Fraction(2, 8), new Fraction(8, 32), true };
            yield return new object[] { new Fraction(9, 10), new Fraction(4, 9), false };
            yield return new object[] { new Fraction(1, 100), new Fraction(5, 25), false };
        }
    }
}
