using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    public class ComplexNumber
    {
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public ComplexNumber(double real) : this(real, 0) { }

        public ComplexNumber() : this(0, 0) { }

        public double Real
        {
            get { return real; }
            set { real = value; }
        }

        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public static ComplexNumber I { get; } = new ComplexNumber(0, 1);

        public static ComplexNumber Zero { get; } = new ComplexNumber(0, 0);

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.Real * b.Real - a.Imaginary * b.Imaginary, a.Real * b.Imaginary + a.Imaginary * b.Real);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
            return new ComplexNumber((a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator, (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator);
        }

        public double Modulus()
        {
            return Math.Sqrt(real * real + imaginary * imaginary);
        }

        public ComplexNumber Power(int n)
        {
            ComplexNumber result = new ComplexNumber(1);
            for (int i = 0; i < n; i++)
            {
                result *= this;
            }
            return result;
        }

        public static ComplexNumber[] SumOfNeighbors(ComplexNumber[] A)
        {
            ComplexNumber[] C = new ComplexNumber[A.Length - 1];
            for (int i = 0; i < C.Length; i++)
            {
                double modulus = (A[i] + A[i + 1]).Modulus();
                C[i] = new ComplexNumber(modulus, 0);
            }
            return C;
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
