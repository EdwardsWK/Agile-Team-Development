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
            clsReview AReview = new clsReview();
            // Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            AReview.ReviewID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.ReviewID, TestData);
        }

        [TestMethod]
        public void ProductIDPropertyOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            AReview.ProductID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.ProductID, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            AReview.CustomerID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.CustomerID, TestData);
        }

        [TestMethod]
        public void ReviewDatePropertyOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create some test data
            DateTime TestData = DateTime.Now;
            // Assign the data to the property
            AReview.ReviewDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.ReviewDate, TestData);
        }

        [TestMethod]
        public void CommentsPropertyOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create some test data
            String TestData = "Test data";
            // Assign the data to the property
            AReview.Comments = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.Comments, TestData);
        }

        [TestMethod]
        public void RatingPropertyOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create some test data
            Int32 TestData = 5;
            // Assign the data to the property
            AReview.Rating = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.Rating, TestData);
        }

        [TestMethod]
        public void ApprovedPropertyOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create some test data
            Boolean TestData = false;
            // Assign the data to the property
            AReview.Approved = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(AReview.Approved, TestData);
        }

    }
}
