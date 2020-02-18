using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalculatorLibrary
    {
        public int add(int a, int b)
        {
            if (a >= int.MaxValue && b > 0 || b >= int.MaxValue && a > 0)
            {
                throw new System.OverflowException();
            }
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException();
            }
            return a / b;
        }
    }
}
