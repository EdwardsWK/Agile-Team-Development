using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingReview
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);
        }

        [TestMethod]
        public void ReviewIDPropertyOK()
        {
            // Create an instance of the Review class
            clsReview Areview = new clsReview();
            // Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            Areview.OrderID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(Areview.OrderID, TestData);
        }

        [TestMethod]
        public void isOrderPlacedOK()
        {
            // Create an instance of the Review class
            Areview Areview = new Areview();
            // Create some test data
            DateTime TestData = DateTime.Now;
            // Assign the data to the property
            Areview.OrderPlaced = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(Areview.OrderPlaced, TestData);
        }

        [TestMethod]
        public void isCustomerIDOK()
        {
            // Create an instance of the Review class
            Areview Areview = new Areview();
            // Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            Areview.CustomerID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(Areview.CustomerID, TestData);
        }

        [TestMethod]
        public void isProductIDOK()
        {
            // Create an instance of the Review class
            Areview Areview = new Areview();
            // Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            Areview.ProductID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(Areview.ProductID, TestData);
        }

        [TestMethod]
        public void isOrderTotalOK()
        {
            // Create an instance of the Review class
            Areview Areview = new Areview();
            // Create some test data
            Double TestData = 1725.99;
            // Assign the data to the property
            Areview.OrderTotal = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(Areview.OrderTotal, TestData);
        }

        [TestMethod]
        public void isOrderCompleted()
        {
            // Create an instance of the Review class
            Areview Areview = new Areview();
            // Create some test data
            Boolean TestData = false;
            // Assign the data to the property
            Areview.OrderCompleted = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(Areview.OrderCompleted, TestData);
        }

    }
}
