using System;


namespace C__Practice_modul_08_ua
{
    public struct Fraction
    {
        public int Numerator;
        public int Denominator;

        private void Simplify()
        {
            int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= gcd;
            Denominator /= gcd;
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public Fraction Add(Fraction other)
        {
            Fraction result;
            result.Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            result.Denominator = Denominator * other.Denominator;
            result.Simplify();
            return result;
        }

        public Fraction Subtract(Fraction other)
        {
            Fraction result;
            result.Numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            result.Denominator = Denominator * other.Denominator;
            result.Simplify();
            return result;
        }

        public Fraction Multiply(Fraction other)
        {
            Fraction result;
            result.Numerator = Numerator * other.Numerator;
            result.Denominator = Denominator * other.Denominator;
            result.Simplify();
            return result;
        }

        public Fraction Divide(Fraction other)
        {
            if (other.Numerator == 0)
                throw new DivideByZeroException("Error.");

            Fraction result;
            result.Numerator = Numerator * other.Denominator;
            result.Denominator = Denominator * other.Numerator;
            result.Simplify();
            return result;
        }


        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
