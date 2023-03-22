using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the the supplier ID property
        private Int32 mSupplierID;
        public int SupplierID
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierID;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierID = value;
            }
        }
        private string mSupplierName;
        public string SupplierName
        {
            get
            {
                //this line of code sends data out of the property
                return mSupplierName;
            }
            set
            {
                //this line of code allows data into the property
                mSupplierName = value;
            }
        }
        private string mSupplierAddress;
        public string SupplierAddress
        {
            get
            {
                //this line of code sends data
                return mSupplierAddress;
            }
            set
            {
                //this line of code allows data
                mSupplierAddress = value;
            }
        }
        private DateTime mContractDate;
        public DateTime ContractDate
        {
            get
            {
                //this line of code sends data
                return mContractDate;
            }

            set
            {
                //this line of code allows data
                mContractDate = value;
            }
        }
        private string mEmailAddress;
        public string EmailAddress
        {
            get
            {
                //this line of code sends data
                return mEmailAddress;
            }
            set
            {
                //this line of code allows data
                mEmailAddress = value;
            }
        }
        private string mTelephoneNo;
        public string TelephoneNo
        {
            get
            {
                //this line of code sends data
                return mTelephoneNo;
            }
            set
            {
                //this line of code allows data 
                mTelephoneNo = value;
            }
        }
        private bool mCurrentSupplier;
        public bool CurrentSupplier
        {
            get
            {
                //this line of code sends data
                return mCurrentSupplier;
            }
            set
            {
                //this line of code allows data
                mCurrentSupplier = value;
            }
        }

        public bool Find(int SupplierID)
        {
            //create an instance opf the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@SupplierID", SupplierID);
            //execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");
            //if one record is found
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mContractDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ContactDate"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mTelephoneNo = Convert.ToString(DB.DataTable.Rows[0]["SupplierNumber"]);
                mCurrentSupplier = Convert.ToBoolean(DB.DataTable.Rows[0]["CurrentSupplier"]);
                //always return true
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;

            }
        }
    }
}
