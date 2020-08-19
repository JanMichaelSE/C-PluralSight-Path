using System;

namespace ConsoleCalculator
{
    public class CalculationNotSupportedException : CalculationException
    {
        public string Operation { get; }

        public CalculationNotSupportedException() : base("Spoecified operations out of range")
        {

        }

        public CalculationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        public CalculationNotSupportedException(string message , Exception innerException) : base (message, innerException)
        {

        }

        public CalculationNotSupportedException(string operation , string message) : base(message)
        {
            Operation = operation;
        }


        public override string Message
        {
            get
            {
                string message = base.Message;

                if (Operation != null)
                {
                    return message + Environment.NewLine + $"Unsupported operation: {Operation}";
                }

                return message;
            }
        }
    }
}
