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

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the OrderID
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderPlacedFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the property
            if (AnOrder.OrderPlaced != Convert.ToDateTime("22/03/2023 19:12:27"))
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the property
            if (AnOrder.CustomerID != 32)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderNotesFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the property
            if (AnOrder.OrderNotes != "Test Notes")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the property
            if (AnOrder.ProductID != 15)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTotalFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the property
            if (AnOrder.OrderTotal != 18.99)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderCompletedFound()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 OrderID = 1;
            // Invoke the method
            Found = AnOrder.Find(OrderID);
            // Check the property
            if (AnOrder.OrderCompleted != true)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
