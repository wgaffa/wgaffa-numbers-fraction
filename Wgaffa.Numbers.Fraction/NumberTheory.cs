using System;

namespace Wgaffa.Numbers
{
    public static class NumberTheory
    {
        public static int GreatestCommonDivisor(int first, int second)
        {
            first = Math.Abs(first);
            second = Math.Abs(second);

            while (second != 0)
            {
                int temp = second;
                second = first % second;
                first = temp;
            }

            return first;
        }

        public static int LeastCommonMultiple(int first, int second)
        {
            if (first == 0 && second == 0)
                return 0;

            return Math.Abs(first * second) / GreatestCommonDivisor(first, second);
        }
    }
}
