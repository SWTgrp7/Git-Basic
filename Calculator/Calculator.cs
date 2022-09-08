using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Accumulator { get; private set; }


        public double Divide(double dividend, double divisor)
        {
            Accumulator = dividend / divisor;
            return dividend / divisor;
        }

        // Overloading functions 

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }
        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }
        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }
    }
}
