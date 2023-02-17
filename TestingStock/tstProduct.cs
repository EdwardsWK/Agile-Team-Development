using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStock
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsProduct aProduct = new clsProduct();

            // test to see that it exists
            Assert.IsNotNull(aProduct);
        }

        [TestMethod]
        public void ProductIDPresent()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Create some test data for the ProductNo Class
            Int32 TestProduct = 1;

            // Assign data to the Property
            Product.ProductID = TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(Product.ProductID, TestProduct);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Create some test data for the ProductNo Class
            String TestProduct = "Acer Inspire";

            // Assign data to the Property
            Product.ProductName = TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(Product.ProductName, TestProduct);
        }

        [TestMethod]
        public void ProductDateAddedOK()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Create some test data for the ProductNo Class
            DateTime TestProduct = DateTime.Now.Date;

            // Assign data to the Property
            Product.DateAdded = TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(Product.DateAdded, TestProduct);
        }

        [TestMethod]
        public void ProductStockCountOK()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Create some test data for the ProductNo Class
            Int32 TestProduct = 13;

            // Assign data to the Property
            Product.StockCount = TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(Product.StockCount, TestProduct);
        }

        [TestMethod]
        public void ProductPriceOK()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Create some test data for the ProductNo Class
            float TestProduct = 699.99f;

            // Assign data to the Property
            Product.Price = (float)TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(Product.Price, TestProduct);
        }

        [TestMethod]
        public void ProductAvailable()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Create some test data for the ProductNo Class
            Boolean TestProduct = true;

            // Assign data to the Property
            Product.Available = TestProduct;

            // Test to see that the two values are the same
            Assert.AreEqual(Product.Available, TestProduct);
        }



    }
}
