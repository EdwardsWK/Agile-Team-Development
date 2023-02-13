using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingSupplier
{
    [TestClass]
    public class UnitTest1Supplier
    {
        [TestMethod]
        public void TestMethod1()
        {
        }




        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }


    }
}
