using System;

namespace CalculatorAppExceptionDemo
{
    class OperationLibrary
    {
        /// <summary>
        /// This is add method which take two integer parameter and return its sum
        /// </summary>
        /// <param name="a">First Value</param>
        /// <param name="b">Seond Value</param>
        /// <returns>return the sum</returns>
        public static int add(int a, int b)
        {
            if (a >= int.MaxValue && b > 0 || a > 0 && b >= int.MaxValue)
                throw new LimitExtendedException();
            return a + b;
        }

        /// <summary>
        /// This is sub method which take two integer parameter and return its difference
        /// </summary>
        /// <param name="a">First Value</param>
        /// <param name="b">Seond Value</param>
        /// <returns>return the value after subtraction</returns>
        public static int sub(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// This is mul method which take two integer parameter and return after multiplication
        /// </summary>
        /// <param name="a">First Value</param>
        /// <param name="b">Seond Value</param>
        /// <returns>return the value after multiplication</returns>
        public static int mul(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// This is div method which take two integer parameter and return after division
        /// </summary>
        /// <param name="a">First Value</param>
        /// <param name="b">Seond Value</param>
        /// <returns>return the value after division</returns>
        public static int div(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            return a / b;

        }
    }
}

