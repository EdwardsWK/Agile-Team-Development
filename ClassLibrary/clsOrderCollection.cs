using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        // Private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
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
                //TODO: WE SHALL WORRY ABOUT THIS LATER
            }
        }
        
        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            // Var for the index
            Int32 Index = 0;

            // Var to store the record count
            Int32 RecordCount = 0;

            // Object for data connection
            clsDataConnection DB = new clsDataConnection();

            // Execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");

            // Get the counbt of records
            RecordCount = DB.Count;

            // While there are records to process
            while (Index < RecordCount)
            {
                // Create a blank order
                clsOrder AnOrder = new clsOrder();

                // Read in the fields from the current order
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
    }
}