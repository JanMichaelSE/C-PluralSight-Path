using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //--Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
            };
            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            Customer c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            Customer c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount++;

            Customer c3 = new Customer();
            c3.FirstName = "Bill";
            Customer.InstanceCount++;

            //--Act
            

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                LastName = "Bilbo",
                EmailAddress = "test@gmail.com"
            };

            var expected = true;

            //--Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
