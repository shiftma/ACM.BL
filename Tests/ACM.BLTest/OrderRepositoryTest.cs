using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class OrderRepositoryTest
    {

        [TestMethod]
        public void RetriveValid()
        {
            var orderRepository = new OrderRepository();

            var expected = new Order(2)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 7, 13, 10, 00, 00, new TimeSpan(7, 0, 0)),
            };

        var actual = orderRepository.Retrive(2);

            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

    }
}
