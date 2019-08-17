using Ardalis.GuardClauses;
using System;

namespace Wgaffa.Numbers
{
    public class Fraction : IEquatable<Fraction>
    {
        public int Sign { get; }
        public int Denominator { get; } = 1;
        public int Numerator { get; }

        public int ProperNumerator { get; }

        public Fraction(int numerator, int denominator = 1)
        {
            Guard.Against.Zero(denominator, nameof(denominator));

            Sign = numerator < 0 ^ denominator < 0 ? -1 : 1;

            Numerator = Math.Abs(numerator);
            Denominator = Math.Abs(denominator);

            var gcd = NumberTheory.GreatestCommonDivisor(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator == 1)
                ProperNumerator = 0;
            else
                ProperNumerator = Numerator < Denominator ? Numerator : Numerator % Denominator;
        }

        public bool Equals(Fraction other)
        {
            if (ReferenceEquals(null, other))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Sign == other.Sign 
                && Numerator == other.Numerator 
                && Denominator == other.Denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (Convert.ToInt32(obj) is int wholeNumber)
                return Equals(new Fraction(wholeNumber));

            if (obj is string fractionString && int.TryParse(fractionString, out int parsedInt))
                return Equals(new Fraction(parsedInt));

            if (obj.GetType() != typeof(Fraction))
                return false;

            return Equals(obj as Fraction);
        }

        public static explicit operator int(Fraction other)
        {
            return other.Numerator / other.Denominator;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            var whole = Numerator / Denominator;
            var sign = Sign < 0 ? "-" : string.Empty;

            if (ProperNumerator == 0)
                return $"{sign}{whole}";

            if (whole == 0)
                return $"{sign}{Numerator}/{Denominator}";
            else
                return $"{sign}{whole} {ProperNumerator}/{Denominator}";
        }
    }
}
