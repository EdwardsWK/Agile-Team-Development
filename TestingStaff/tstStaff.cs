using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass to the method
        string StaffFirstName = "Samuel";
        string StaffLastName = "Doolan";
        string StaffEmail = "p2672389@my365.dmu.ac.uk";
        string StaffPassword = "01";
        string StaffDateJoined = DateTime.Now.Date.ToString();
        
        [TestMethod]
        public void InstanceOK()
        {
            //creat an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void StaffFirstNamePropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AStaff.StaffFirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffFirstName, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AStaff.StaffLastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void StaffEmailPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffPasswordPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AStaff.StaffPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPassword, TestData);
        }

        [TestMethod]
        public void StaffDateJoinedPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AStaff.StaffDateJoined = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffDateJoined, TestData);
        }

        [TestMethod]
        public void StaffIsManagerPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.StaffIsManager = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffIsManager, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffID != 1)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFirstNameFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffFirstName != "Samuel")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffLastNameFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffLastName != "Doolan")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffEmail != "P2672389@my365.dmu.ac.uk")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffPassword != "01")
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDateJoinedFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffDateJoined != Convert.ToDateTime("01/01/2023"))
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsManagerFound()
        {
            // Create an instance of the order class
            clsStaff AStaff = new clsStaff();
            // Boolean variable to store the result of the search
            Boolean Found = false;
            // Boolean variable to record if data is OK
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 StaffID = 1;
            // Invoke the method
            Found = AStaff.Find(StaffID);
            // Check the OrderID
            if (AStaff.StaffIsManager != true)
            {
                OK = false;
            }
            // Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
        //create an instance of the class we want to create
        clsStaff AStaff = new clsStaff();
        //string variable to store any error message
        String Error = "";
        //invoke the method
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
        //test to see that the result is correct
        Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "S";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "Sa";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(49, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(50, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(51, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(25, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffFirstName = "";
            StaffFirstName = StaffFirstName.PadRight(200, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "D";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "Do";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(49, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(50, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(51, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(25, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffLastNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffLastName = "";
            StaffLastName = StaffLastName.PadRight(200, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "p";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "Do";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(49, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(200, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordNameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "0";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "01";
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(49, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(50, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(51, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(25, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(200, 'e');
            //invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

       [TestMethod]
        public void StaffDateJoinedExtremeMin()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            String StaffDateJoined = DateTime.Now.Date.AddYears(-100).ToString();
            // Invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateJoinedMinLessOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            String StaffDateJoined = DateTime.Now.Date.AddDays(-1).ToString();
            // Invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateJoinedMin()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            String StaffDateJoined = DateTime.Now.Date.ToString();
            // Invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateJoinedMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            String StaffDateJoined = DateTime.Now.Date.AddDays(1).ToString();
            // Invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateJoinedExtremeMax()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            String StaffDateJoined = DateTime.Now.Date.AddYears(100).ToString();
            // Invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffDateJoinedInvalidData()
        {
            // Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            // String variable to store any error message
            String Error = "";
            // Create a variable to store the test date data
            String StaffDateJoined = "fred";
            // Invoke the method
            Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
