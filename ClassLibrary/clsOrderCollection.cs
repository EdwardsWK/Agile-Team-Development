using System.Collections.Generic;
using System;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // Private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        // Private data member thisOrder
        clsOrder mThisOrder = new clsOrder();

        // Public property for the Order List
        public List<clsOrder> OrderList
        {
            get
            {
                // Return the private data
                return mOrderList;
            }
            set
            {
                // Set the private data
                mOrderList = value;
            }
        }

        // Public property for count
        public int Count
        {
            get
            {
                // Return the count of the list
                return mOrderList.Count;
            }
            set
            {
            }
        }
        
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }
        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the parameter DB
            // Var for the index
            Int32 Index = 0;

            // Var to store the record count
            Int32 RecordCount;

            // Get the count of records
            RecordCount = DB.Count;

            // Clear the private array list
            mOrderList = new List<clsOrder>();

            // While there are no records to process
            while (Index < RecordCount)
            {
                // Create a blank Order
                clsOrder AnOrder = new clsOrder();

                // Read in the fields from the current record
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.OrderPlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderPlaced"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.OrderNotes = Convert.ToString(DB.DataTable.Rows[Index]["OrderNotes"]);
                AnOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrder.OrderTotal = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderTotal"]);
                AnOrder.OrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderCompleted"]);

                // Add the record to the private data member
                mOrderList.Add(AnOrder);

                // Point at the next record
                Index++;
            }
        }

        // Constructor for the class
        public clsOrderCollection()
        {
            // Object for data connection
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");

            // Populate the array list with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            // Adds a new record to the database based on the values of mThisAddress
            // Set the primary key value of the new record
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@OrderPlaced", mThisOrder.OrderPlaced);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@OrderNotes", mThisOrder.OrderNotes);
            DB.AddParameter("@OrderTotal", mThisOrder.OrderTotal);
            
            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Update()
        {
            // Update an existing record based on the values of the thisOrder
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the store procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@OrderPlaced", mThisOrder.OrderPlaced);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@ProductID", mThisOrder.ProductID);
            DB.AddParameter("@OrderNotes", mThisOrder.OrderNotes);
            DB.AddParameter("@OrderTotal", mThisOrder.OrderTotal);
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by ThisOrder
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Set the parameters for the stored procedure
            DB.AddParameter("@OrderID", mThisOrder.OrderID);

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByProductID(int productID)
        {
            // Filters the records based on the ProductID
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();

            // Workaround for test ReportByProductIDMethodOK
            // and for the OrderList clear button
            // Check if the ProductID passed is minus 999
            if (productID == -999)
            {
                DB.Execute("sproc_tblOrder_SelectAll");
            }
            // If the productID is any other value
            else
            {
                // Send the ProductID parameter to the database
                DB.AddParameter("@ProductID", productID);

                // Execute the store procedure
                DB.Execute("sproc_tblOrder_FilterByProductID");
            }

            // Populate the array list with the data table
            PopulateArray(DB);
        }
    }
}