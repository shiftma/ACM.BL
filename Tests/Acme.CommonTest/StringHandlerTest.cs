using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTestValid()  
        {
            var source = "SonicViewdriver";
            var expected = "Sonic Viewdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertSpaceTestWithExistingSpace()
        {
            var source = "Sonic Viewdriver";
            var expected = "Sonic Viewdriver";

            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
