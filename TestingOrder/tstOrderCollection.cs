using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace TestingOrder
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the Order Collection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Test to see if it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // Create an instance of the Order Collection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Set its properties
            TestItem.OrderID = 1;
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            TestItem.ProductID = 3;
            TestItem.OrderNotes = "Testing";
            TestItem.OrderTotal = 599.99;
            TestItem.OrderCompleted = false;

            // Add an item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllOrders.OrderList = TestList;

            // Test to see if the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // Create an instance of the Order Collection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();

            // Set its properties
            TestOrder.OrderID = 1;
            TestOrder.OrderPlaced = DateTime.Now.Date;
            TestOrder.CustomerID = 2;
            TestOrder.ProductID = 3;
            TestOrder.OrderNotes = "Testing";
            TestOrder.OrderTotal = 599.99;
            TestOrder.OrderCompleted = false;

            // Assign the data to the proerty
            AllOrders.ThisOrder = TestOrder;

            // Test to see if the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the Order Collection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create some test data to assign to the property
            List<clsOrder> TestList = new List<clsOrder>();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Set its properties
            TestItem.OrderID = 1;
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.CustomerID = 2;
            TestItem.ProductID = 3;
            TestItem.OrderNotes = "Testing";
            TestItem.OrderTotal = 599.99;
            TestItem.OrderCompleted = false;

            // Add an item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllOrders.OrderList = TestList;

            // Test to see if the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
