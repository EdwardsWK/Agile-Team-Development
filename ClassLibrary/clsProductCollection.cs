using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {

        // Private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();

        // Private data member thisProduct
        clsProduct mThisProduct = new clsProduct();

        public int Count
        {
            get
            {
                // Return the count of the list
                return mProductList.Count;
            }
            set
            {
                // to be modified later
            }
        }

        public List<clsProduct> productList
        {
            get
            {
                // Return the private data
                return mProductList;
            }
            set
            {
                // Set the private data
                mProductList = value;
            }
        }

        // Constructor for the class
        public clsProductCollection()
        {
            // DB connection
            clsDataConnection DB = new clsDataConnection();

            // Execute stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");

            // Populate array with data table
            PopulateArray(DB);

        }

        public clsProduct ThisProduct
        {
            get
            {
                // Return the private data
                return mThisProduct;
            }
            set
            {
                // Set the private data
                mThisProduct = value;
            }
        }

        public int Add()
        {
            // Adds a new record to the database based on the values of mThisProduct
            // DB Connection
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@StockCount", mThisProduct.StockCount);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Available", mThisProduct.Available);

            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Update()
        {
            // Update an existing record based on the values of thisProduct
            // Connect to DB
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);
            DB.AddParameter("@StockCount", mThisProduct.StockCount);
            DB.AddParameter("@Price", mThisProduct.Price);
            DB.AddParameter("@Available", mThisProduct.Available);

            // Execute the query 
            DB.Execute("sproc_tblProduct_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by thisProduct
            // Connect to DB
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);

            // Execute the query 
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void ReportByProductName(string ProductName)
        {
            // filters the records based on a full or partial product ID
            // Connect to DB
            clsDataConnection DB = new clsDataConnection();

            // Send the product name parameter to the DB
            DB.AddParameter("@ProductName", ProductName);

            // Execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductName");

            // Populate array with the data table
            PopulateArray(DB);
        }
        
        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array based on the data table in the parameter DB
            // Var for the index
            Int32 Index = 0;

            // Var to store the record count
            Int32 RecordCount;

            // Get the count of records
            RecordCount = DB.Count;

            // Clear the private array list
            mProductList = new List<clsProduct>();

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank product
                clsProduct Product = new clsProduct();

                // Read in the fields from the current record
                Product.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                Product.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                Product.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                Product.StockCount = Convert.ToInt32(DB.DataTable.Rows[Index]["StockCount"]);
                Product.Price = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                Product.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);

                // Add the record to the private data member
                mProductList.Add(Product);

                // Point at the next record
                Index++;
            }
        }
    }
}