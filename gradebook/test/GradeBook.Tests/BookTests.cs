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


        }
    }
}
