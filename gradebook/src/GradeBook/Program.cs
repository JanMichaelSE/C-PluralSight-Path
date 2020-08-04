using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Juan");
            book.AddGrade(51);
            book.AddGrade(31);
            book.AddGrade(21);

            // Computes and Shows results
            var stats = book.GetStatistics();

            Console.WriteLine($"Avegrae-->{stats.Average:N1}, Highest-->{stats.Highest}, Lowest-->{stats.Lowest}");
        }
    }
}
