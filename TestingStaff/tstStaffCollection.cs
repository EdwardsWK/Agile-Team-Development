﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
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
            //modify the test data
            TestItem.StaffFirstName = "Jim";
            TestItem.StaffLastName = "Doherty";
            TestItem.StaffEmail = "p2723645@my365.dmu.ac.uk";
            TestItem.StaffPassword = "07";
            TestItem.StaffDateJoined = DateTime.Now.Date;
            TestItem.StaffIsManager = false;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see if ThisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
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
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByLastNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a blank string (should return all records)
            FilteredStaff.ReportByLastName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a Last Name that doesnt exist
            FilteredStaff.ReportByLastName("xxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByLastNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a Last Name that doesnt exist
            FilteredStaff.ReportByLastName("aaaaaaaaa");
            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaff.StaffList[0].StaffID != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStaff.StaffList[1].StaffID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
