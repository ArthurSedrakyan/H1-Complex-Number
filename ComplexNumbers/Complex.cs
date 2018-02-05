

using System;

namespace ComplexNumbers
{
    public class Complex
    {
        private double real;
        private double lip;

        public double Real
        {
            get { return real; }
        }

        public double Lip
        {
            get { return lip; }
        }

        public Complex(double real, double lip)
        {
            this.real = real;
            this.lip = lip;
        }

        public Complex()
        {
            real = 0;
            lip = 0;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.lip + c2.lip);
        }

        
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c2.real, c1.lip - c2.lip);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            double _real = c1.real * c2.real - c1.lip * c2.lip;
            double _lip = c1.real * c2.lip + c1.lip * c2.real;
            return new Complex(_real, _lip);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double declaration = c2.real * c2.real + c2.lip * c2.lip;
            double _real = (c1.real * c2.real + c1.lip * c2.lip) / declaration;
            double _lip = (c1.lip * c2.real - c1.real * c2.lip) / declaration;
            return new Complex(_real, _lip);
        }

    
        public override string ToString()
        {
            if (lip == 1)
                return $"{real} + i";

            if (lip == -1)
                return $"{real} - i";

            if (lip == 0)
                return $"{real}";

            return $"{real} + ({lip})i";

        }
    }
}