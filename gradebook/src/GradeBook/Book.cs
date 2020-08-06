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

        public void AddLetterGrade(char letter)
        {
            switch (letter)
            {

                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Highest = double.MinValue;
            result.Lowest = double.MaxValue;

            for (var index = 0; index < grades.Count; index++)
            {
                // Gets Highest
                result.Highest = Math.Max(grades[index], result.Highest);

                // Gets lowest
                result.Lowest = Math.Min(grades[index], result.Lowest);

                // Accumilator
                result.Average += grades[index];

            }

            result.Average /= grades.Count;

            switch (result.Average)
            {
                case var average when average >= 90:
                    result.Letter = 'A';
                    break;

                case var average when average >= 80 && average < 90:
                    result.Letter = 'B';
                    break;

                case var average when average >= 70 && average < 80:
                    result.Letter = 'C';
                    break;

                case var average when average >= 60 && average < 70:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }

    }
}