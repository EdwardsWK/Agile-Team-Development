using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStaff
{
    [TestClass]
    public class tstStaff
    {
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
            if (AStaff.StaffEmail != "p2672389@my365.dmu.ac.uk")
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
            if (AStaff.StaffDateJoined != Convert.ToDateTime("14/02/2023"))
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

    }
}
