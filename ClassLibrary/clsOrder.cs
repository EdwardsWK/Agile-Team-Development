using System;

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

            // Create a temporary variable to store OrderTotal
            Decimal TempOrderTotal;

            // Validation for the OrderPlaced field
            try
            {
                // Copy the orderPlaced value to the temporary variable
                TempOrderPlaced = Convert.ToDateTime(orderPlaced);

                // Check to see if The Order Placed date is less than today's date
                if (TempOrderPlaced < DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The Order Placed date cannot be in the past : ";
                }

                // Check to see if The Order Placed date is greater than today's date
                if (TempOrderPlaced > DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The Order Placed date cannot be in the future : ";
                }
            }
            // If the orderPlaced field is not a date
            catch
            {
                // Record the error
                Error = Error + "The Order Placed date was not a valid date : ";
            }

            // Validation for the CustomerID field
            try
            {
                // Copy the CustomerID value to the temporary variable
                TempCustomerID = Convert.ToInt32(customerID);

                // Check if the CustomerID is less than one
                if (TempCustomerID < 1)
                {
                    // Record the error
                    Error = Error + "The Customer ID cannot be less than 1 : ";
                }
            }
            // If the CustomerID is more than the maximum Int32 value
            catch (OverflowException)
            {
                // Record the error
                Error = Error + "The Customer ID cannot be higher than 2,147,483,647 : ";
            }
            // If the CustomerID is not a number
            catch (FormatException)
            {
                // Record the error
                Error = Error + "The Customer ID was not a valid number : ";
            }

            // Validation for The Product ID field
            try
            {
                // Copy The Product ID value to the temporary variable
                TempProductID = Convert.ToInt32(productID);

                if (TempProductID < 1)
                {
                    // Record the error
                    Error = Error + "The Product ID cannot be less than 1 : ";
                }
            }
            // If The Product ID is more than the maximum Int32 value
            catch (OverflowException)
            {
                // Record the error
                Error = Error + "The Product ID cannot be higher than 2,147,483,647 : ";
            }
            // If The Product ID is not a number
            catch (FormatException)
            {
                // Record the error
                Error = Error + "The Product ID was not a valid number : ";
            }

            // Validation for the OrderNotes field
            // If OrderNotes is longer than 250 characters
            if (orderNotes.Length > 250)
            {
                // Record the error
                Error = Error + "Order Notes cannot exceed 250 characters : ";
            }

            // Validation for the Order Total field
            try
            {
                TempOrderTotal = Convert.ToDecimal(orderTotal);

                // If the Order Total is less than 0.01
                if (TempOrderTotal < 100.00M)
                {
                    // Record the error
                    Error = Error + "The Order Total cannot be less than £100.00 : ";
                }
                // If the Order Total is more than 99999.99
                if (TempOrderTotal > 99999.99M)
                {
                    // Record the error
                    Error = Error + "The Order Total cannot be more than £99999.99 : ";
                }
                if (TempOrderTotal != Math.Round(TempOrderTotal, 2))
                {
                    // Record the error
                    Error = Error + "The Order Total cannot contain more than two decimal places : ";
                }
            }
            // If the Order Total is not a number
            catch
            {
                Error = Error + "The Order Total was not a valid number : ";
            }

            // Return any error messages
            return Error;
        }
    }
}