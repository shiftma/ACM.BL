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
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bingo",
                LastName = "Bongo"
            };
            string expected = "Bongo, Bingo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameMissingTest()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Bingo"
            };
            string expected = "Bingo";

            //--Act
            string actual = customer.FullName;

            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            var c1 = new Customer();
            c1.FirstName = "Booka";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Peach";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Apple";
            Customer.InstanceCount += 1;
            //--Act

            //--Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Bublik",
                EmailAddress = "bublik@here.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

    }
}
