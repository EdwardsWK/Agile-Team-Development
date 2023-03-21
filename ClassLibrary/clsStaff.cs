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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the StaffID to search for
            DB.AddParameter("@StaffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mStaffFirstName = Convert.ToString(DB.DataTable.Rows[0]["StaffFirstName"]);
                mStaffLastName = Convert.ToString(DB.DataTable.Rows[0]["StaffLastName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPassword = Convert.ToString(DB.DataTable.Rows[0]["StaffPassword"]);
                mStaffDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateJoined"]);
                mStaffIsManager = Convert.ToBoolean(DB.DataTable.Rows[0]["isManager"]);
                //return that everything worked OK
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