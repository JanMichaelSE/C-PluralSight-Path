using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculationException : System.Exception
    {
        private static readonly string DefaultMessage = "An error occured during calculations. (Default message)";

        public CalculationException() : base (DefaultMessage)
        {

        }

        public CalculationException(string message)  : base (message)
        {

        }

        public CalculationException(Exception innerException) : base (DefaultMessage, innerException)
        {

        }

        public CalculationException(string message, Exception innerException) :  base (message, innerException)
        {

        }
    }
}
