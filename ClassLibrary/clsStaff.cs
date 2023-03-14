using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                //Return the private data
                return mStaffID;
            }
            set
            {
                //Set the private data
                mStaffID = value;
            }
        }

        private String mStaffFirstName;
        public string StaffFirstName
        {
            get
            {
                //Return the private data
                return mStaffFirstName;
            }
            set
            {
                //Set the private data
                mStaffFirstName = value;
            }
        }

        private String mStaffLastName;
        public string StaffLastName
        {
            get
            {
                //Return the private data
                return mStaffLastName;
            }
            set
            {
                //Set the private data
                mStaffLastName = value;
            }
        }

        private String mStaffEmail;
        public string StaffEmail
        {
            get
            {
                //Return the private data
                return mStaffEmail;
            }
            set
            {
                //Set the private data
                mStaffEmail = value;
            }
        }

        private String mStaffPassword;
        public string StaffPassword
        {
            get
            {
                //Return the private data
                return mStaffPassword;
            }
            set
            {
                //Set the private data
                mStaffPassword = value;
            }
        }

        private DateTime mStaffDateJoined;
        public DateTime StaffDateJoined
        {
            get
            {
                //Return the private data
                return mStaffDateJoined;
            }
            set
            {
                //Set the private data
                mStaffDateJoined = value;
            }
        }

        private Boolean mStaffIsManager;
        public bool StaffIsManager
        {
            get
            {
                //Return the private data
                return mStaffIsManager;
            }
            set
            {
                //Set the private data
                mStaffIsManager = value;
            }
        }

        public bool Find(int staffID)
        {
            //Set the private data members to test data value
            mStaffID = 1;
            mStaffFirstName = "FirstName";
            mStaffLastName = "LastName";
            mStaffEmail = "Email";
            mStaffPassword = "Password";
            mStaffDateJoined = Convert.ToDateTime("25/12/2022");
            mStaffIsManager = true;
            //always return true
            return true;
        }
    }
}