using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }

        public double Highest;
        public double Lowest;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var average when average >= 90:
                        return 'A';

                    case var average when average >= 80 && average < 90:
                        return 'B';

                    case var average when average >= 70 && average < 80:
                        return 'C';

                    case var average when average >= 60 && average < 70:
                        return 'D';

                    default:
                        return 'F';

                }

            }
        }

        public double Sum;
        public int Count;

        public Statistics()
        {
            Sum = 0.0;
            Highest = double.MinValue;
            Lowest = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count++;

            // Gets Highest
            Highest = Math.Max(number, Highest);

            // Gets lowest
            Lowest = Math.Min(number, Lowest);
        }
    }
}