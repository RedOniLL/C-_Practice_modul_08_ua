using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Practice_modul_08_ua
{
    public struct ComplexNumber
    {
        public double RealPart;
        public double ImaginaryPart;

        public ComplexNumber Add(ComplexNumber other)
        {
            ComplexNumber result;
            result.RealPart = RealPart + other.RealPart;
            result.ImaginaryPart = ImaginaryPart + other.ImaginaryPart;
            return result;
        }
        public ComplexNumber Subtract(ComplexNumber other)
        {
            ComplexNumber result;
            result.RealPart = RealPart - other.RealPart;
            result.ImaginaryPart = ImaginaryPart - other.ImaginaryPart;
            return result;
        }
        public ComplexNumber Multiply(ComplexNumber other)
        {
            ComplexNumber result;
            result.RealPart = RealPart * other.RealPart - ImaginaryPart * other.ImaginaryPart;
            result.ImaginaryPart = RealPart * other.ImaginaryPart + ImaginaryPart * other.RealPart;
            return result;
        }
        public ComplexNumber Divide(ComplexNumber other)
        {
            if (other.RealPart == 0 && other.ImaginaryPart == 0)
                throw new DivideByZeroException("Error.");

            ComplexNumber result;
            double denominator = other.RealPart * other.RealPart + other.ImaginaryPart * other.ImaginaryPart;
            result.RealPart = (RealPart * other.RealPart + ImaginaryPart * other.ImaginaryPart) / denominator;
            result.ImaginaryPart = (ImaginaryPart * other.RealPart - RealPart * other.ImaginaryPart) / denominator;
            return result;
        }

        public override string ToString()
        {
            if (ImaginaryPart >= 0)
                return $"{RealPart} + {ImaginaryPart}i";
            else
                return $"{RealPart} - {-ImaginaryPart}i";
        }
    }
}
