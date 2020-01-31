using System;

namespace CalculatorAppExceptionDemo
{
    /// <summary>
    /// This is calculator class in which both predefiend and custom Exception are implemented
    /// </summary>
    class CalculatorApp
    {
        /// <summary>
        /// Main class to call the methods and handle the exception here.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            int a = 98, b = 0;
            int result = 0;

            
            // Showing the handling of divide by zero Exception
            try
            {
                result = OperationLibrary.div(a, b);
                Console.WriteLine("{0} divided by {1} = {2}", a, b, result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Attempted divide by zero.");
            }

            Console.WriteLine();

            // Showing the Custom Exception
            int firstVal = int.MaxValue, secondval = int.MaxValue;
            try
            {
                result = OperationLibrary.add(firstVal, secondval);
                Console.WriteLine("{0} add by {1}={2}", firstVal, secondval, result);
            }
            catch (LimitExtendedException ex)
            {
                // Prints the user defined message in the custom exception
                Console.WriteLine(ex.Message());
            }
            Console.ReadLine();
        }
    }
}
