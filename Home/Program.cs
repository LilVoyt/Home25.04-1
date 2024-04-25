using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Program
    {
        static void Main()
        {
            ComplexNumber number = new ComplexNumber(3, 5);
            Console.WriteLine(number);
            ComplexNumber number1 = new ComplexNumber(5, 2);
            Console.WriteLine(number1);
            Console.WriteLine($"After adding: {ComplexNumber.Adding(number, number1)}");
            Console.WriteLine($"After multiplication: {ComplexNumber.Multiplication(number, number1)}");
            Console.WriteLine($"After division: {ComplexNumber.Division(number, number1)}");

            ComplexNumber number3 = number + number1;
            Console.WriteLine($"The same but with operator: {number3}");

        }
    }
}
