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

    }
}
