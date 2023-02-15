using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Imag { get; set; }
        public void Add(Complex x)
        {
            Real+= x.Real;
            Imag+= x.Imag;
        }
        public void Subtract(Complex x)
        {
            Real-= x.Real;
            Imag-= x.Imag;
        }
        public void Multiply(Complex x)
        {
            double real = Real * x.Real - Imag * x.Imag;
            double imag = Real * x.Imag + Imag * x.Real;
            Real = real;
            Imag = imag;
        }

        public void Divide(Complex x)
        {
            double denominator = x.Real * x.Real + x.Imag * x.Imag;
            double real = (Real * x.Real + Imag * x.Imag) / denominator;
            double imag = (Imag * x.Real - Real * x.Imag) / denominator;
            Real = real;
            Imag = imag;
        }
    }
}
