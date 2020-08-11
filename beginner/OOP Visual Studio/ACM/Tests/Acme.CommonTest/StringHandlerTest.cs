using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "Sonic Screw";
            var expected = "Sonic Screw";

            // Act 
            var actual = source.InsertSpaces();


            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
