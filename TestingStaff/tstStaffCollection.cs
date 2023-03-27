using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;

namespace TestingStaff
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the clas we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Samuel";
            TestItem.StaffLastName = "Doolan";
            TestItem.StaffEmail = "p2672389@my365.dmu.ac.uk";
            TestItem.StaffPassword = "01";
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffIsManager = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.StaffID = 1;
            TestStaff.StaffFirstName = "Samuel";
            TestStaff.StaffLastName = "Doolan";
            TestStaff.StaffEmail = "p2672389@my365.dmu.ac.uk";
            TestStaff.StaffPassword = "01";
            TestStaff.StaffDateJoined = DateTime.Now.Date;
            TestStaff.StaffIsManager = true;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Samuel";
            TestItem.StaffLastName = "Doolan";
            TestItem.StaffEmail = "p2672389@my365.dmu.ac.uk";
            TestItem.StaffPassword = "01";
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffIsManager = true;
        }

        [TestMethod]
        public void AddMethod()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.StaffID = 1;
            TestItem.StaffFirstName = "Samuel";
            TestItem.StaffLastName = "Doolan";
            TestItem.StaffEmail = "p2672389@my365.dmu.ac.uk";
            TestItem.StaffPassword = "01";
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffIsManager = true;
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }



    }
}
