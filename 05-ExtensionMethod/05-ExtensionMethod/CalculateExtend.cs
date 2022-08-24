using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExtensionMethod
{
    public static class CalculateExtend
    {
        public static int Sub(this ICalculate calculate, int a, int b)
        {
            return a - b;
        }

        public static int Multiply(this ICalculate calculate, int a, int b)
        {
            return a * b;
        }
    }
}
