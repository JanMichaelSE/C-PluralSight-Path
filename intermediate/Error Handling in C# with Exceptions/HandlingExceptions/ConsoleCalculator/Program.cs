using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain currentAppDomain = AppDomain.CurrentDomain;
            currentAppDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(HandleException);

            var calculator = new Calculator();

            Console.Write("Enter type of operation-->");
            var operation = Console.ReadLine();

            Console.Write("Enter Numerator-->");
            var numerator = int.Parse(Console.ReadLine());

            Console.Write("Enter Denominator-->");
            var denominator = int.Parse(Console.ReadLine());

            try
            {
                var result = calculator.Calculate(numerator, denominator, operation);

                Console.WriteLine($"Your result is {result}");
            }
            catch (ArgumentNullException ex) when (ex.ParamName == "operation") /// Exception filters
            {
                Console.WriteLine($"Operation not given {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Operation not supported {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("...Finally...");
            }
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"Sorry something went wrong and we are shutting down--> {e.ExceptionObject}");
        }
    }
}
