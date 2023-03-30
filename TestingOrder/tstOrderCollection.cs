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
            // Create an instance of the OrderCollection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Test to see if it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // Create an instance of the OrderCollection class
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
            // Create an instance of the OrderCollection class
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
            // Create an instance of the OrderCollection class
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

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the OrderCollection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Var to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.CustomerID = 999;
            TestItem.ProductID = 333;
            TestItem.OrderNotes = "Add Test";
            TestItem.OrderTotal = 999.99;

            // Set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;

            // Add the record
            PrimaryKey = AllOrders.Add();

            // Set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            // Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the OrderCollection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Var to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.CustomerID = 555;
            TestItem.ProductID = 777;
            TestItem.OrderNotes = "Update Test";
            TestItem.OrderTotal = 999.99;

            // Set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;

            // Add the record
            PrimaryKey = AllOrders.Add();

            // Set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            // Modify the test data
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.CustomerID = 111;
            TestItem.ProductID = 222;
            TestItem.OrderNotes = "Update Test Success";
            TestItem.OrderTotal = 333.33;
            TestItem.OrderCompleted = true;

            // Set the record based on the new test data
            AllOrders.ThisOrder = TestItem;

            // Update the record
            AllOrders.Update();

            // Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the OrderCollection class
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create the item of test data
            clsOrder TestItem = new clsOrder();

            // Var to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.OrderPlaced = DateTime.Now.Date;
            TestItem.CustomerID = 987;
            TestItem.ProductID = 654;
            TestItem.OrderNotes = "Delete Test";
            TestItem.OrderTotal = 321.12;

            // Set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;

            // Add the record
            PrimaryKey = AllOrders.Add();

            // Set the primary key of the test data
            TestItem.OrderID = PrimaryKey;

            // Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);

            // Delete the record
            AllOrders.Delete();

            // Now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            // Test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByProductIDMethodOK()
        {
            // Create an instance of the OrderCollection class containing unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();

            // Create an instance of the OrderCollection class containing filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Apply a  string (Should return all records)
            FilteredOrders.ReportByProductID(-999);

            // Test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductIDNoneFound()
        {
            // Create an instance of the OrderCollection class containing filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Apply a ProductID that doesn't exist
            FilteredOrders.ReportByProductID(0);

            // Test to see that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByProductIDDataFound()
        {
            // Create an instance of the OrderCollection class containing filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();

            // Var to store outcome
            Boolean OK = true;

            // Apply a ProductID that doesn't exist
            FilteredOrders.ReportByProductID(54321);

            // Check that the correct number of records are found
            if (FilteredOrders.Count == 2)
            {
                // Check if the first record's CustomerID is 121
                if (FilteredOrders.OrderList[0].CustomerID != 121)
                {
                    OK = false;
                }
                // Check if the first record's CustomerID is 121
                if (FilteredOrders.OrderList[1].CustomerID != 95)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            // Test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}