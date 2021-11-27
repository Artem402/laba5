using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class OrdinaryCalc
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }

    }
    class AdvancedCalc : OrdinaryCalc
    {
        public double Sqrt(int x)
        {
            return Math.Sqrt(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
