using System;

namespace MathsApplication
{

    /*
    The main Math class
    Contains Add and Subtract methods for performing basic math functions
   */


    /// <summary>
    /// This  is the main Math methord
    /// Contains the Maths methord for Double and Integer type
    /// </summary>

    /// <remarks>
    /// This contains the Add and Subtract Methord
    /// </remarks>

    public class Math
    {
        // Adds two integers and returns the result

        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>

        ///<returns>
        ///Returns the submission of two Integer type numbers
        /// </returns>

        ///<example>
        /// <code>
        /// int c = Math.Add(4, 5);
        /// if (c > 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>

        /// <exception cref="System.OverflowException">Thrown when one parameter is max 
        /// and the other is greater than 0.</exception>

        public static int Add(int a, int b)
        {
            // If any parameter is equal to the max value of an integer
            // and the other is greater than zero
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Adds two doubles and returns the result

        /// <summary>
        /// Adds two Double and returns the result.
        /// </summary>

        ///<returns>
        ///Returns the submission of two Double type numbers
        /// </returns>

        /// <exception cref="System.OverflowException">Thrown when one parameter is max 
        /// and the other is greater than zero.</exception>

        /// See <see cref="Math.Add(int, int)"/> to add integers.
        public static double Add(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new System.OverflowException();

            return a + b;
        }

        // Subtracts an integer from another and returns the result
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        // Subtracts a double from another and returns the result
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
    }

    //Driver Class
    class Program
    {
        static void Main(string[] args)
        {
            int c = Math.Add(4, 5);
            if (c > 10)
            {
                Console.WriteLine("Hey I am here");
                Console.WriteLine(c);
                Console.ReadLine();
            }
        }
    }
}
