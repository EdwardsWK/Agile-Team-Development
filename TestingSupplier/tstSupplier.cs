using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingSupplier
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            ASupplier.SupplierNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierNumber, TestData);
        }
        [TestMethod]
        public void SupplierNamePropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            ASupplier.SupplierName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierAddressPropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            ASupplier.SupplierAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierAddress, TestData);
        }
        [TestMethod]
        public void ContactDatePropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            ASupplier.ContactDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.ContactDate, TestData);
        }
        [TestMethod]
        public void EmailAddressPropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            ASupplier.EmailAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.EmailAddress, TestData);
        }
        [TestMethod]
        public void SupplierNumberPropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierNumber, TestData);
        }
        [TestMethod]
        public void CurrentSupplierPropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ASupplier.CurrentSupplier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.CurrentSupplier, TestData);
        }
    }

 }
