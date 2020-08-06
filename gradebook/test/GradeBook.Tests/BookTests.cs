using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrad()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89);
            book.AddGrade(29);
            book.AddGrade(99);

            // act
            var result = book.GetStatistics();


            // assert
            Assert.Equal(99, result.Highest);
            Assert.Equal(29, result.Lowest);
            Assert.Equal(72.33, result.Average, 2);
            Assert.Equal('C', result.Letter);


        }


        [Fact]
        public void AddGradesBetween0and100()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(105);

            var book2 = new Book("");
            book2.AddGrade(-1);

            // Both values return NaN because only grades between 0 and 100 can be added
            Assert.Equal(book2.GetStatistics().Average, book.GetStatistics().Average);

        }
    }
}
