using System;
using System.Diagnostics;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Private data member for OrderID
        Int32 mOrderID;
        public int OrderID
        {
            get
            {
                // Return the private data
                return mOrderID;
            }
            set
            {
                // Set the private data
                mOrderID = value;
            }
        }

        // Private data member for OrderID
        DateTime mOrderPlaced;
        public DateTime OrderPlaced
        {
            get
            {
                // Return the private data
                return mOrderPlaced;
            }
            set
            {
                // Set the private data
                mOrderPlaced = value;
            }
        }

        // Private data member for OrderID
        Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                // Return the private data
                return mCustomerID;
            }
            set
            {
                // Set the private data
                mCustomerID = value;
            }
        }

        // Private data member for OrderID
        String mOrderNotes;
        public string OrderNotes
        {
            get
            {
                // Return the private data
                return mOrderNotes;
            }
            set
            {
                // Set the private data
                mOrderNotes = value;
            }
        }

        // Private data member for OrderID
        Int32 mProductID;
        public int ProductID
        {
            get
            {
                // Return the private data
                return mProductID;
            }
            set
            {
                // Set the private data
                mProductID = value;
            }
        }

        // Private data member for OrderID
        Double mOrderTotal;
        public double OrderTotal
        {
            get
            {
                // Return the private data
                return mOrderTotal;
            }
            set
            {
                // Set the private data
                mOrderTotal = value;
            }
        }

        // Private data member for OrderID
        Boolean mOrderCompleted;
        public bool OrderCompleted
        {
            get
            {
                // Return the private data
                return mOrderCompleted;
            }
            set
            {
                // Set the private data
                mOrderCompleted = value;
            }
        }

        public bool Find(int orderID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the Order ID to search for
            DB.AddParameter("@OrderID", orderID);

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderID");

            // If one record is found
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mOrderPlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderPlaced"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderNotes = Convert.ToString(DB.DataTable.Rows[0]["OrderNotes"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mOrderTotal = Convert.ToDouble(DB.DataTable.Rows[0]["OrderTotal"]);
                mOrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderCompleted"]);
                
                // Return that everything worked okay
                return true;
            }
            // If no record was found
            else
            {
                // Return false indicating a problem
                return false;
            }
        }

        public string Valid(string orderPlaced, string customerID, string orderNotes, string productID, string orderTotal)
        {
            // Create a string variable to store the error
            String Error = "";

            // Create a temporary variable to store date values
            DateTime TempOrderPlaced;

            // Create a temporary variable to store CustomerID
            Int32 TempCustomerID;

            // Create a temporary variable to store ProductID
            Int32 TempProductID;

            try
            {
                // Copy the orderPlaced value to the temporary variable
                TempOrderPlaced = Convert.ToDateTime(orderPlaced);

                if (TempOrderPlaced < DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                // Check to see if the date is greater than today's date
                if (TempOrderPlaced > DateTime.Now.Date)
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

            try
            {
                // Copy the customerID value to the temporary variable
                TempCustomerID = Convert.ToInt32(customerID);

                if (TempCustomerID < 1)
                {
                    // Record the error
                    Error = Error + "The CustomerID cannot be less than 1 : ";
                }
            }
            catch (OverflowException)
            {
                // Handle IntegerOverflow exception
                Error = "The CustomerID cannot be higher than 2,147,483,647: ";
            }
            catch (FormatException)
            {
                // Handle FormatException
                Error = "The CustomerID was not a valid number : ";
            }

            // If the OrderNotes are greater than 250 characters
            if (orderNotes.Length > 250)
            {
                // Record the error
                Error = Error + "The house no must be less than 6 characters : ";
            }

            try
            {
                // Copy The ProductID value to the temporary variable
                TempProductID = Convert.ToInt32(productID);

                if (TempProductID < 1)
                {
                    // Record the error
                    Error = Error + "The ProductID cannot be less than 1 : ";
                }
            }
            catch (OverflowException)
            {
                // Handle IntegerOverflow exception
                Error = "The ProductID cannot be higher than 2,147,483,647: ";
            }
            catch (FormatException)
            {
                // Handle FormatException
                Error = "The ProductID was not a valid number : ";
            }

            /*
             * 
             * INSERT VALIDATION FOR ORDERTOTAL HERE
             * 
             */

            // Return any error messages
            return Error;
        }
    }
}