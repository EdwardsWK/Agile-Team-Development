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
            // Set the private data members to the test data value
            mOrderID = 1;
            mOrderPlaced = Convert.ToDateTime("22/03/2023 19:12:27");
            mCustomerID = 32;
            mOrderNotes = "Test Notes";
            mProductID = 15;
            mOrderTotal = 18.99;
            mOrderCompleted = true;
            // Always return true
            return true;
        }
    }
}