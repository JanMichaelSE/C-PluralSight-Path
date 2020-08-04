using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {

        private List<double> grades;
        private string name;

        public Book(string aName)
        {
            grades = new List<double>();
            name = aName;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

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