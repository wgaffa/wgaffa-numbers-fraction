using NUnit.Framework;

namespace Wgaffa.Numbers.Tests
{
    [TestFixture]
    public class GreatestCommonDivisorTests
    {
        [TestCase(45, 18, ExpectedResult = 9)]
        [TestCase(35, 3, ExpectedResult = 1)]
        [TestCase(40, 175, ExpectedResult = 5)]
        public int GreatestCommonDivisor_ShouldCalculate(int first, int second)
        {
            return NumberTheory.GreatestCommonDivisor(first, second);
        }

        [TestCase(-3, -9, ExpectedResult = 3)]
        [TestCase(-49, 14, ExpectedResult = 7)]
        public int GreatestCommonDivisor_ShouldCalculate_GivenNegativeValues(int first, int second)
        {
            return NumberTheory.GreatestCommonDivisor(first, second);
        }
    }
}
