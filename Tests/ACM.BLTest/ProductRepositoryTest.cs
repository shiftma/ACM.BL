using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    /// <summary>
    /// Summary description for ProductRepositoryTest
    /// </summary>
    [TestClass]
    public class ProductRepositoryTest
    {

        [TestMethod]
        public void RetrieveValid() 
        {
            ProductRepository productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductId = 5,
                ProductName = "Danon",
                CurrentPrice = 12.36M,
        };

            var actual = productRepository.Retrieve(1);

            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductId, actual.ProductId);

        }
    }
}
