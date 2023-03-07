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

        public bool Find(int productID)
        {
            // Set the private data members to the following test data
            mProductID = 1;
            mProductName = "Acer";
            mDateAdded = Convert.ToDateTime("12/12/2001");
            mStockCount = 5;
            mPrice = (float)Convert.ToDouble(199.99);
            mAvailable = true;

            // always return true
            return true;

        }
    }
}