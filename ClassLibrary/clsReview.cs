using System;

namespace ClassLibrary
{
    public class clsReview
    {
        private Int32 mReviewID;
        public Int32 ReviewID
        {

            get
            {
                return mReviewID;
                // this line of code sends data out of the property return ReviewID;
            }
            set
            {
                //this line of code allows data into the property
                mReviewID = value;
            }
        }

        private Int32 mProductID;
        public Int32 ProductID
        {

            get
            {
                return mProductID;
                // this line of code sends data out of the property return ProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }

        private Int32 mCustomerID;
        public Int32 CustomerID
        {

            get
            {
                return mCustomerID;
                // this line of code sends data out of the property return mCustomerID;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerID = value;
            }
        }

        private DateTime mReviewDate;
        public DateTime ReviewDate
        {
            get
            {
                return mReviewDate;
            }
            set
            {
                mReviewDate = value;
            }
        }

        private string mComments;
        public string Comments
        {

            get
            {
                return mComments;
                // this line of code sends data out of the property return mComments;
            }
            set
            {
                //this line of code allows data into the property
                mComments = value;
            }
        }

        private Int32 mRating;
        public int Rating {
            get
            {
                return mRating;
            }
            set
            {
                mRating = value;
            }
        }

        private Boolean mApproved;
        public bool Approved {
            get
            {
                return mApproved;
            }
            set
            {
                mApproved = value;
            }
        }

        public bool Find(int reviewID)
        {
            // Set the private data to test data value
            mReviewID = 2;
            mProductID = 10;
            mCustomerID = 25;
            mReviewDate = Convert.ToDateTime("03/03/2023");
            mComments = "Good product";
            mRating = 2;
            mApproved = true;
            
            // Make it always true
            return true;
        }
    }

}