using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "gogogly@go.com",
                FirstName = "gogoo"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);

        }

        [TestMethod]
        public void RetriveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "foo@foo.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                        {
                            new Address()
                            {
                                AddressType = 1,
                                StreetLine1 = "Bagaboo",
                                StreetLine2 = "Nemogu",
                                City = "Kansas",
                                Country = "US",
                                PostalCode = "12345"
                            },
                            new Address()
                            {
                                AddressType = 2,
                                StreetLine1 = "Pickapoo",
                                StreetLine2 = "Lyamur",
                                City = "Kansas",
                                Country = "US",
                                PostalCode = "12345"
                            }
                        }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i=0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
