using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingStock
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Test to see that it exists
            Assert.IsNotNull(allProducts);
        }

        [TestMethod]
        public void ProductListOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create some test data to assign to the property.
            // In this case, the data needs to be a list of objects.
            List<clsProduct> TestList = new List<clsProduct>();

            // Add an item to the list
            // Create the item of test data
            clsProduct TestItem = new clsProduct();

            // Set the properties
            TestItem.ProductID = 1;
            TestItem.ProductName = "Some Name";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockCount = 3;
            TestItem.Price = 300.00f;
            TestItem.Available = true;

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign Data to the property
            allProducts.productList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.productList, TestList);

        }

        [TestMethod]
        public void ThisProductPropertyOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create some test data to assign to the property.
            clsProduct TestProduct = new clsProduct();

            // Set the properties
            TestProduct.ProductID = 1;
            TestProduct.ProductName = "Some Name";
            TestProduct.DateAdded = DateTime.Now.Date;
            TestProduct.StockCount = 3;
            TestProduct.Price = 300.00f;
            TestProduct.Available = true;

            // Assign Data to the property
            allProducts.ThisProduct = TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.ThisProduct, TestProduct);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create some test data to assign to the property.
            // In this case, the data needs to be a list of objects.
            List<clsProduct> TestList = new List<clsProduct>();

            // Add an item to the list
            // Create the item of test data
            clsProduct TestItem = new clsProduct();

            // Set the properties
            TestItem.ProductID = 1;
            TestItem.ProductName = "Some Name";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockCount = 3;
            TestItem.Price = 300.00f;
            TestItem.Available = true;

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign Data to the property
            allProducts.productList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create the item of test data
            clsProduct TestItem = new clsProduct();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set the properties
            TestItem.ProductID = 1;
            TestItem.ProductName = "Some Name";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockCount = 3;
            TestItem.Price = 300.00f;
            TestItem.Available = true;

            // Set This.Product to the test data
            allProducts.ThisProduct = TestItem;

            // Add the record
            PrimaryKey = allProducts.Add();

            // Set the Primary key of the test data
            TestItem.ProductID = PrimaryKey;

            // Find the record
            allProducts.ThisProduct.Find(PrimaryKey);

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create the item of test data
            clsProduct TestItem = new clsProduct();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set the properties
            TestItem.ProductName = "Some Name";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockCount = 3;
            TestItem.Price = 300.00f;
            TestItem.Available = true;

            // Set This.Product to the test data
            allProducts.ThisProduct = TestItem;

            // Add the record
            PrimaryKey = allProducts.Add();

            // Set the Primary key of the test data
            TestItem.ProductID = PrimaryKey;

            // Modify the test data
            TestItem.ProductName = "Some Other Name";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockCount = 5;
            TestItem.Price = 699.99f;
            TestItem.Available = true;

            // Set the record based on the new test data
            allProducts.ThisProduct = TestItem;

            // Update the record
            allProducts.Update();

            // Find the record
            allProducts.ThisProduct.Find(PrimaryKey);

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.ThisProduct, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create the item of test data
            clsProduct TestItem = new clsProduct();

            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set the properties
            TestItem.ProductID = 1;
            TestItem.ProductName = "Some Name";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StockCount = 3;
            TestItem.Price = 300.00f;
            TestItem.Available = true;

            // Set This.Product to the test data
            allProducts.ThisProduct = TestItem;

            // Add the record
            PrimaryKey = allProducts.Add();

            // Set the Primary key of the test data
            TestItem.ProductID = PrimaryKey;

            // Find the record
            allProducts.ThisProduct.Find(PrimaryKey);

            // Delete the record
            allProducts.Delete();

            // Find the record
            Boolean Found = allProducts.ThisProduct.Find(PrimaryKey);

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.ThisProduct, TestItem);
        }

        [TestMethod]
        public void ReportByProductNameMethodOK()
        {
            // Create an Instance of the class we want to create
            clsProductCollection allProducts = new clsProductCollection();

            // Create an instance of filtered data
            clsProductCollection filteredProducts = new clsProductCollection();

            // Apply a blank string (Should return in all records)
            filteredProducts.ReportByProductName("");

            // Test to see that the two values are the same
            Assert.AreEqual(allProducts.Count, filteredProducts.Count);

        }

        [TestMethod]
        public void ReportByProductNameNoneFound()
        {

            // Create an instance of filtered data
            clsProductCollection filteredProducts = new clsProductCollection();

            // Apply a ProductName that doesnt exist 
            filteredProducts.ReportByProductName("XXXXXXX");

            // Test to see that there are no records
            Assert.AreEqual(0, filteredProducts.Count);

        }

        [TestMethod]
        public void ReportByProductNameTestDataFound()
        {

            // Create an instance of filtered data
            clsProductCollection filteredProducts = new clsProductCollection();

            // Var to store outcome
            Boolean OK = true;

            // Apply a ProductName that doesnt exist 
            filteredProducts.ReportByProductName("XXXXXXX");

            // Check that the correct number of records are found
            if (filteredProducts.Count == 2)
            {
                // Check that the first record is ID 36
                if (filteredProducts.productList[0].ProductID != 36)
                {
                    OK = false;
                }

                // Check that the first record is ID 37
                if (filteredProducts.productList[1].ProductID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            // Test to see that there are no records
            Assert.IsTrue(OK);

        }

    }
}
