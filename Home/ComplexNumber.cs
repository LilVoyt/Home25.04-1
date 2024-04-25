using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal struct ComplexNumber
    {
        public double A { get; set; }
        public double B { get; set; }


        public ComplexNumber(double A = 0, double B = 0)
        {
            this.A = A;
            this.B = B;
        }

        public static ComplexNumber Adding(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber res = new ComplexNumber();
            res.A = number1.A + number2.A;
            res.B = number2.B + number1.B;
            return res;
        }
        public static ComplexNumber Subtraction(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber res = new ComplexNumber();
            res.A = number1.A - number2.A;
            res.B = number2.B - number1.B;
            return res;
        }
        public static ComplexNumber Multiplication(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber res = new ComplexNumber();
            res.A = (number1.A * number2.A) - (number1.B * number2.B);
            res.B = (number1.A * number2.B) + (number1.B * number2.A);
            return res;
        }
        public static ComplexNumber Division(ComplexNumber number1, ComplexNumber number2)
        {
            ComplexNumber res = new ComplexNumber();
            res.A = ((number1.A * number2.A) + (number1.B * number2.B)) /
                (Math.Sqrt(number2.A) + Math.Sqrt(number2.B));
            res.B = ((number1.A * number2.B) - (number1.B * number2.A)) /
                (Math.Sqrt(number2.A) + Math.Sqrt(number2.B));
            return res;
        }
        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return Adding(number1, number2);
        }
        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return Subtraction(number1, number2);
        }
        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            return Multiplication(number1, number2);
        }
        public static ComplexNumber operator /(ComplexNumber number1, ComplexNumber number2)
        {
            return Subtraction(number1, number2);
        }
        public override string ToString()
        {
            return $"{A} + {B}i";
        }
    }
}
