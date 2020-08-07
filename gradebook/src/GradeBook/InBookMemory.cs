using System;
using System.Collections.Generic;

namespace GradeBook
{

    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class InMemoryBook : Book
    {

        private List<double> grades;
        public const string _category = "";

        public InMemoryBook(string name) : base(name)
        {
            grades = new List<double>();
        }

        // Every function has its signiture defined by the parameters. So you can overload and use the desired function depending
        //  on the arguement being passed in this case AddGrade(double) or AddGrade(char)
        public void AddGrade(char letter)
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

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            for (var index = 0; index < grades.Count; index++)
            {
                result.Add(grades[index]);
            }

            return result;
        }
    }
}