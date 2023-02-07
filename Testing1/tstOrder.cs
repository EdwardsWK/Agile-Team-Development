using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Test to see that it exists
            Assert.IsNotNull(AnOrder);//creat an instance of the class we want to create
        }
    }
}
