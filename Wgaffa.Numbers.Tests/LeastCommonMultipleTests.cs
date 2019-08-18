using NUnit.Framework;

namespace Wgaffa.Numbers.Tests
{
    [TestFixture]
    public class LeastCommonMultipleTests
    {
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(21, 8, ExpectedResult = 168)]
        [TestCase(-3, 32, ExpectedResult = 96)]
        public int LeastCommonMultiple_ShouldCalculate(int first, int second)
        {
            return NumberTheory.LeastCommonMultiple(first, second);
        }
    }
}
