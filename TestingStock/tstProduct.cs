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

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Create some test data to use with the method
            Int32 ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductIDFound()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Boolean variable to record if data is ok (Assume that it is)
            Boolean OK = true;

            // Create some test data to use with the method
            Int32 ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Check the ProductID
            if (Product.ProductID != 1)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductNameFound()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Boolean variable to record if data is ok (Assume that it is)
            Boolean OK = true;

            // Create some test data to use with the method
            int ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Check the Product Name
            if (Product.ProductName != "Acer Laptop" )
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Boolean variable to record if data is ok (Assume that it is)
            Boolean OK = true;

            // Create some test data to use with the method
            int ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Check the Product DateAdded
            if (Product.DateAdded != Convert.ToDateTime("08/03/2023"))
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockCountFound()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Boolean variable to record if data is ok (Assume that it is)
            Boolean OK = true;

            // Create some test data to use with the method
            int ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Check the Product Stock Count
            if (Product.StockCount != 1)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Boolean variable to record if data is ok (Assume that it is)
            Boolean OK = true;

            // Create some test data to use with the method
            int ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Check the Product Price
            if (Product.Price != (float)Convert.ToDouble(499.99))
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            // Create an instance of the ProductNo Class
            clsProduct Product = new clsProduct();

            // Boolean variable to store the results of the validation
            Boolean Found = false;

            // Boolean variable to record if data is ok (Assume that it is)
            Boolean OK = true;

            // Create some test data to use with the method
            int ProductID = 1;

            // Invoke the method
            Found = Product.Find(ProductID);

            // Check the Product Name
            if (Product.Available != true)
            {
                OK = false;
            }

            // Test to see if the result is true
            Assert.IsTrue(Found);
        }
    }
}
