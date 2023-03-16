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
            Int32 TestData = 1;
            //assign the data to the property
            ASupplier.SupplierID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.SupplierID, TestData);
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
        public void ContractDatePropertyOK()
        {

            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "12/03/2023";
            //assign the data to the property
            ASupplier.ContractDate = Convert.ToDateTime(TestData);
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.ContractDate, TestData);
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
        public void TelephoneNoPropertyOK()
        {
            //create an instance of their class we want to create
            clsSupplier ASupplier = new clsSupplier();
            //create some test data to assign to the property
            String TestData = "01234567890";
            //assign the data to the property
            ASupplier.TelephoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ASupplier.TelephoneNo, TestData);
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
