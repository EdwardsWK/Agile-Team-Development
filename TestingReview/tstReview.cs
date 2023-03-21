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

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the Review class
            clsReview AReview = new clsReview();
            // Create Boolean variable to store the result
            Boolean Found = false;
            // Create a test data to use with method
            Int32 ReviewID = 2;
            //Invoke the method
            Found = AReview.Find(ReviewID);
            // Test to see that if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestReviewIDFound()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewID = 2;
            //invoke the method
            Found = AReview.Find(ReviewID);
            //check the ReviewID
            if (AReview.ReviewID != 2)
            {
                OK = false;
            }
            // test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestReviewDateFound()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewID = 2;
            //invoke the method
            Found = AReview.Find(ReviewID);
            //check the property
            if (AReview.ReviewDate != Convert.ToDateTime("03/03/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewID = 2;
            //invoke the method
            Found = AReview.Find(ReviewID);
            //check the CustomerID
            if (AReview.CustomerID != 25)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewID = 2;
            //invoke the method
            Found = AReview.Find(ReviewID);
            //check the value
            if (AReview.ProductID != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

            [TestMethod]

            public void TestCommentsFound()
            {
                //create an instance of the class we want to create
                clsReview AReview = new clsReview();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 ReviewID = 2;
                //invoke the method
                Found = AReview.Find(ReviewID);
                //check the property
                if (AReview.Comments != "Good product")
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

        [TestMethod]

        public void TestRatingFound()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewID = 2;
            //invoke the method
            Found = AReview.Find(ReviewID);
            //check the property
            if (AReview.Rating != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestApprovedFound()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ReviewID = 2;
            //invoke the method
            Found = AReview.Find(ReviewID);
            //check the property
            if (AReview.Approved != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
    }
