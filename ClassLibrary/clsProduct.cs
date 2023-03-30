using System;

namespace ClassLibrary
{
    public class clsProduct
    {
        private int mProductID;

        public int ProductID
        {
            get
            {
                // send out data out of the property
                return mProductID;
            }
            set
            {
                // allow data into the property
                mProductID = value;
            }
        }

        private string mProductName;

        public string ProductName
        {
            get
            {
                // send out data out of the property
                return mProductName;
            }
            set
            {
                // allow data into the property
                mProductName = value;
            }
        }

        private DateTime mDateAdded;

        public DateTime DateAdded
        {
            get
            {
                // send out data out of the property
                return mDateAdded;
            }
            set
            {
                // allow data into the property
                mDateAdded = value;
            }
        }

        private int mStockCount;
        public int StockCount
        {
            get
            {
                // send out data out of the property
                return mStockCount;
            }
            set
            {
                // allow data into the property
                mStockCount = value;
            }
        }

        private float mPrice;

        public float Price
        {
            get
            {
                // send out data out of the property
                return mPrice;
            }
            set
            {
                // allow data into the property
                mPrice = value;
            }
        }

        private Boolean mAvailable;

        public bool Available
        {
            get
            {
                // send out data out of the property
                return mAvailable;
            }
            set
            {
                // allow data into the property
                mAvailable = value;
            }
        }

        public bool Find(int ProductID)
        {

            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the ProductID to search by
            DB.AddParameter("@ProductID", ProductID);
            // Execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductID");
            // If one record is found...
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members...
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mStockCount = Convert.ToInt32(DB.DataTable.Rows[0]["StockCount"]);
                mPrice = (float)Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);

                // Return that everything worked ok
                return true;
            }
            // If no record is found...
            else
            {
                // Return false indicating a problem
                return false;
            }

        }

        public string Valid(string productName, string dateAdded, string stockCount, string price)
        {
            // Create a string variable to store the error
            String Error = "";

            // Create a temporary variable for date values
            DateTime TempDate;

            // Create a temporary variable for stock count
            Int32 TempStockCount;

            // Create a temporary variable for Price
            float TempPrice;

            // If the ProductName is blank
            if (productName.Length == 0)
            {
                // Record the error
                Error = Error + "The Product Name may not be set : ";
            }

            // If the product name is greater than 50 characters
            if (productName.Length > 50)
            {
                // Record the error
                Error = Error + "The Product Name must be less than 50 characters : ";
            }

            try
            {
                // Copy the dateAdded value to the TempDate variable
                TempDate = Convert.ToDateTime(dateAdded);
                if (TempDate < DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                // Check to see if the date is greater than today's date
                if (TempDate > DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                // Record the error
                Error = Error + "The date was not a valid date : ";
            }

            
            // Validation for StockCount
            try
            {
                // Copy the StockCount value to a temporary variable
                TempStockCount = Convert.ToInt32(stockCount);

                if (TempStockCount < 0)
                {
                    // Record the error
                    Error = Error + "The StockCount cannot be less than 0 : ";
                }
            }

            // If The StockCount is more than the maximum Int32 value
            catch (OverflowException)
            {
                // Record the error
                Error = Error + "The StockCount cannot be higher than 2,147,483,647 : ";
            }
            // If The StockCount is not a number
            catch (FormatException)
            {
                // Record the error
                Error = Error + "The StockCount was not a valid number : ";
            }

            // Validation for the Order Total field
            try
            {
                TempPrice = (float)Convert.ToDouble(price);

                // If the Price is less than 100
                if (TempPrice < 100.00f)
                {
                    // Record the error
                    Error = Error + "The Price cannot be less than £100.00 : ";
                }
                // If the Price is more than 99999.99
                if (TempPrice > 99999.99f)
                {
                    // Record the error
                    Error = Error + "The Price cannot be more than £99999.99 : ";
                }
            }
            // If the Price is not a number
            catch
            {
                Error = Error + "The Price was not a valid number : ";
            }

            //return any error messages
            return Error;

        }
    }
}