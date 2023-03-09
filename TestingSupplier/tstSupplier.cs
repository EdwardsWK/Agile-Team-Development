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

        public void SupplierIdOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            ASupplier.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierId, TestData);
        }
        public void SupplierNameIdOK()
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
        public void SupplierAddressOK()
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
        public void ContactDateOK()
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
        public void EmailAddressOK()
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
        public void SupplierNumberOK()
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
        public void CurrentSupplierOK()
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
