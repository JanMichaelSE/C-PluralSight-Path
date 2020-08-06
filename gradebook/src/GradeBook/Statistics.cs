namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double Highest;
        public double Lowest;
        public char Letter;

        public Statistics()
        {
            Average = 0.0;
            Highest = double.MinValue;
            Lowest = double.MaxValue;
            Letter = ' ';
        }
    }
}