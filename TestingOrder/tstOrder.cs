using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrder
{
    [TestClass]
    public class tstOrder
    {
        // Good test data
        // Create some test data to pass the method
        String OrderPlaced = DateTime.Now.Date.ToString();
        String CustomerID = "25";
        String ProductID = "13";
        String OrderNotes = "Some test data";
        String OrderTotal = "182.29";

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
            DateTime TestData = DateTime.Now.Date;
            
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
            if (AnOrder.OrderPlaced != Convert.ToDateTime("12/03/2023 14:00:00"))
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
            if (AnOrder.CustomerID != 2)
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
            if (AnOrder.OrderNotes != "Please leave with mailroom")
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
            if (AnOrder.ProductID != 3)
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
            if (AnOrder.OrderTotal != 19.99)
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

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the order class
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that it exists
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedExtremeMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";

            // Create a variable to store the test date data
            String OrderPlaced = DateTime.Now.Date.AddYears(-100).ToString();
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create a variable to store the test date data
            String OrderPlaced = DateTime.Now.Date.AddDays(-1).ToString();

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";

            // Create a variable to store the test date data
            String OrderPlaced = DateTime.Now.Date.ToString();

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create a variable to store the test date data
            String OrderPlaced = DateTime.Now.Date.AddDays(1).ToString();

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedExtremeMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create a variable to store the test date data
            String OrderPlaced = DateTime.Now.Date.AddYears(100).ToString();

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPlacedInvalidData()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create a variable to store the test date data
            String OrderPlaced = "Not a date";

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "-1000000"; // This should fail
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "0"; // This should fail
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "1"; // This should be ok
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "2"; // This should be ok
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "2147483646"; // This should be ok
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "2147483647"; // This should be ok
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "2147483648"; // This should fail
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "1073741823"; // This should be ok
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDInvalidData()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            
            // String variable to store any error message
            String Error = "";
            
            // Create some test data to pass to the method
            string CustomerID = "Not a number"; // This should be ok
            
            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
            
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should pass
            string OrderNotes = "";

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should pass
            string OrderNotes = "e";

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should pass
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(249, 'e');

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should pass
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(250, 'e');

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should fail
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(251, 'e');

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should pass
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(125, 'e');

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderNotesExtremeMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // This should fail
            string OrderNotes = "";
            OrderNotes = OrderNotes.PadRight(750, 'e');

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDExtremeMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "-1000000"; // This should fail

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "0"; // This should fail

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "1"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "2"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "2147483646"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "2147483647"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "2147483648"; // This should fail

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "1073741823"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductIDInvalidData()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductID = "Not a number"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * INSERT TESTS FOR ORDERTOTAL HERE
         * 
         */

        [TestMethod]
        public void OrderTotalExtremeMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "-1000000.00"; // This should fail

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMinLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "99.99"; // This should fail

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMin()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "100.00"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "100.01"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "99999.98"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "99999.99"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "100000.00"; // This should fail

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalMid()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "49949.99"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalExtremeMax()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "99999999.99"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalInvalidData()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "Not a decimal"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderTotalExcessDecimalPlaces()
        {
            // Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            // String variable to store any error message
            String Error = "";

            // Create some test data to pass to the method
            string OrderTotal = "123.555"; // This should be ok

            // Invoke the method
            Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
