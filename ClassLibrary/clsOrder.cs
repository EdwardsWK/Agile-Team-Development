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

        public bool Find(int OrderID)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add the parameter for the Order ID to search for
            DB.AddParameter("@OrderID", OrderID);

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
    }
}