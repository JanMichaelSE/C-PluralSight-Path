using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Highest = double.MinValue;
            result.Lowest = double.MaxValue;

            foreach (var grade in grades)
            {
                // Gets Highest
                result.Highest = Math.Max(grade, result.Highest);

                // Gets lowest
                result.Lowest = Math.Min(grade, result.Lowest);

                // Accumilator
                result.Average += grade;
            }

            result.Average /= grades.Count;

            return result;
        }

    }
}