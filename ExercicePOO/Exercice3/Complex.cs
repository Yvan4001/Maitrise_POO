using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicePOO.Exercice3
{
    internal class Complex
    {
        private double _real;

        public double Real
        {
            get { return _real; }
            set { _real = value; }
        }

        private double _imaginary;

        public double Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        public Complex() { }

        public Complex(double real, double imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public override string ToString()
        {
            return $"({_real},{_imaginary})";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt(Math.Pow(_real,2) + Math.Pow(_imaginary,2));
        }

        public void Sum(Complex complex)
        {
            double tempReal = _real + complex.Real;
            double tempImaginary = _imaginary + complex.Imaginary;
            
            _real = tempReal;
            _imaginary = tempImaginary;
        }
    }
}
