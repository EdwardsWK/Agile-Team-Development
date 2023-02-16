using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStock
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsProduct aProduct = new clsProduct();

            // test to see that it exists
            Assert.IsNotNull(aProduct);
        }
    }
}
