using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Juan");
            var done = false;


            while (!done)
            {

                Console.Write("Enter grade or 'q' to quit-->");
                var input = Console.ReadLine();


                if (input == "q")
                {
                    done = true;
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error was recieved {ex.Message}");

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Runs after exceptions");
                }


            };

            // Computes and Shows results
            var stats = book.GetStatistics();

            Console.WriteLine($"Avegrae-->{stats.Average:N1}, Highest-->{stats.Highest}, Lowest-->{stats.Lowest}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
