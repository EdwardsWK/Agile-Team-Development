using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrder
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
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();

            // Create some test data
            Int32 TestData = 1;

            // Assign the data to the property
            AnOrder.OrderID = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderPlacedPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();

            // Create some test data
            DateTime TestData = DateTime.Now;

            // Assign the data to the property
            AnOrder.OrderPlaced = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPlaced, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();

            // Create some test data
            Int32 TestData = 1;

            // Assign the data to the property
            AnOrder.CustomerID = TestData;

            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();

            // Create some test data
            Int32 TestData = 1;
            
            // Assign the data to the property
            AnOrder.ProductID = TestData;
            
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.ProductID, TestData);
        }

        [TestMethod]
        public void OrderNotesPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            
            // Create some test data
            String TestData = "This is some test data to test the field works correctly";
            
            // Assign the data to the property
            AnOrder.OrderNotes = TestData;
            
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNotes, TestData);
        }

        [TestMethod]
        public void OrderTotalPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            
            // Create some test data
            Double TestData = 1725.99;
            
            // Assign the data to the property
            AnOrder.OrderTotal = TestData;
            
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderTotal, TestData);
        }

        [TestMethod]
        public void OrderCompletedPropertyOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
         
            // Create some test data
            Boolean TestData = false;
            
            // Assign the data to the property
            AnOrder.OrderCompleted = TestData;
            
            // Test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderCompleted, TestData);
        }
    }
}
