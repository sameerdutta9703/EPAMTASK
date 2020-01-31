using System;

namespace CalculatorAppExceptionDemo
{
    /// <summary>
    /// This is custom Exception class defined for handling Overflow addition Exception
    /// </summary>
    class LimitExtendedException : Exception
    {
        public LimitExtendedException()
        {

        }
        /// <summary>
        /// To Give meaningfull exception message
        /// </summary>
        /// <returns>Exception Message</returns>
        public String Message()
        {
            try
            {
                return "Overflow ..this two integer value cannot be added";
            }
            catch (LimitExtendedException ex)
            {
                throw;
            }
        }
    }
}
