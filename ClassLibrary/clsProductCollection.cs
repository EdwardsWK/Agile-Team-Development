using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsProductCollection
    {

        // Private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();

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

        public clsProduct ThisProduct;

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
            // Var for the index
            Int32 Index = 0;

            // Var to store the record count
            Int32 RecordCount = 0;

            // Object for data connection
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("sproc_tblProduct_SelectAll");

            // Get the count of records
            RecordCount = DB.Count;

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank product
                clsProduct Product = new clsProduct();

                // Read in the fields from the current record
                Product.ProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                Product.ProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                Product.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                Product.StockCount = Convert.ToInt32(DB.DataTable.Rows[0]["StockCount"]);
                Product.Price = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                Product.Available = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                // Add the record to the private data member
                mProductList.Add(Product);

                // Point at the next record
                Index++;
            }

        }
        
    }
}