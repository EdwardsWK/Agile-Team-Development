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

        public string Valid(string staffFirstName, string staffLastName, string staffEmail, string staffPassword, string staffDateJoined)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable for date values
            DateTime TempDate;

            // If StaffFirstName is longer than 50 characters
            if (staffFirstName.Length > 50)
            {
                // Record the error
                Error = Error + "The StaffFirstName cannot be more than 50 characters : ";
            }

            // If StaffFirstName is longer than 250 characters
            if (staffFirstName.Length < 1)
            {
                // Record the error
                Error = Error + "The StaffFirstName must be at least 1 character : ";
            }

            // If StaffLastName is longer than 50 characters
            if (staffLastName.Length > 50)
            {
                // Record the error
                Error = Error + "The StaffLastName cannot be more than 50 characters : ";
            }

            // If StaffLastName is longer than 250 characters
            if (staffLastName.Length < 1)
            {
                // Record the error
                Error = Error + "The StaffLastName must be at least 1 character : ";
            }

            // If StaffEmail is longer than 50 characters
            if (staffEmail.Length > 50)
            {
                // Record the error
                Error = Error + "The StaffEmail cannot be more than 50 characters : ";
            }

            // If StaffEmail is longer than 250 characters
            if (staffEmail.Length < 1)
            {
                // Record the error
                Error = Error + "The StaffEmail must be at least 1 character : ";
            }

            // If StaffPassword is longer than 50 characters
            if (staffPassword.Length > 50)
            {
                // Record the error
                Error = Error + "The StaffPassword cannot be more than 50 characters : ";
            }

            // If StaffPassword is longer than 250 characters
            if (staffPassword.Length < 1)
            {
                // Record the error
                Error = Error + "The StaffPassword must be at least 1 character : ";
            }

            try
            {
                // Copy the staffDateJoined value to the temporary variable
                TempDate = Convert.ToDateTime(staffDateJoined);

                // Check to see if the date is less than today's date
                if (TempDate < DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the past : ";
                }

                // Check to see if the date is greater than today's date
                if (TempDate > DateTime.Now.Date)
                {
                    // Record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            // If the staffDateJoined field is not a date
            catch
            {
                // Record the error
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }
    }
}
