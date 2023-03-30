using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingStock
{
    [TestClass]
    public class tstProduct
    {

        // Create some test data
        string ProductName = "Acer";
        string DateAdded = DateTime.Now.Date.ToString();
        string StockCount = "3";
        string Price = "299.99";

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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
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
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void ProductNameMinLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = ""; // this should trigger an error

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "a"; // this should be okay

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "aa"; // this should be okay

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "0123456789012345678901234567890123456789012345678"; // this should be okay

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMax()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "01234567890123456789012345678901234567890123456789"; // this should be okay

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "012345678901234567890123456789012345678901234567890"; // this should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameExtremeMax()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(200, 'a'); // this should fail
            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ProductNameMid()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string ProductName = "0123456789012345678901234"; // this should be okay

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create a variable to store the test data
            DateTime TestDate;

            // Set the date to todays date
            TestDate = DateTime.Now.Date;

            // Change the date to whatever the date is in less than 100 years
            TestDate = TestDate.AddYears(-100);

            // Convert the Date variable to a string variable
            string DateAdded = TestDate.ToString();

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create a variable to store the test data
            DateTime TestDate;

            // Set the date to todays date
            TestDate = DateTime.Now.Date;

            // Change the date to whatever the date is in less than 1 day
            TestDate = TestDate.AddDays(-1);

            // Convert the Date variable to a string variable
            string DateAdded = TestDate.ToString();

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create a variable to store the test data
            DateTime TestDate;

            // Set the date to todays date
            TestDate = DateTime.Now.Date;

            // Convert the Date variable to a string variable
            string DateAdded = TestDate.ToString();

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create a variable to store the test data
            DateTime TestDate;

            // Set the date to todays date
            TestDate = DateTime.Now.Date;

            // Change the date to whatever the date is in more than 1 day
            TestDate = TestDate.AddDays(1);

            // Convert the Date variable to a string variable
            string DateAdded = TestDate.ToString();

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create a variable to store the test data
            DateTime TestDate;

            // Set the date to todays date
            TestDate = DateTime.Now.Date;

            // Change the date to whatever the date is pluss 100 years
            TestDate = TestDate.AddYears(100);

            // Convert the Date variable to a string variable
            string DateAdded = TestDate.ToString();

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create a variable to store the test data
            string DateAdded = "this is not a date";

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void StockCountExtremeMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "-10000000000"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMinLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "-1"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "0"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "1"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "2147483646"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMax()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "2147483647"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "2147483648"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockCountMid()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "1073741823"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockCountInvalidData()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string StockCount = "not a number"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void PriceExtremeMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "-1000000.00"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "99.99"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "100.00"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "100.01"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "99999.98"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "99999.99"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "100000.00"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxMid()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "49949.99"; // This should pass

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "999999999.99"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            // Create an instance of the class we want to create
            clsProduct Product = new clsProduct();

            // String variable to store an error message
            String Error = "";

            // Create some test data to pass to the method
            string Price = "not a decimal"; // This should fail

            // Invoke the method
            Error = Product.Valid(ProductName, DateAdded, StockCount, Price);

            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
