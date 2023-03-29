using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }

        public clsStaffCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        
            
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            _ = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank staff member
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AStaff.StaffDateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateJoined"]);
                AStaff.StaffIsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["isManager"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("@StaffDateJoined", mThisStaff.StaffDateJoined);
            DB.AddParameter("@isManager", mThisStaff.StaffIsManager);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            DB.AddParameter("StaffFirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("StaffLastName", mThisStaff.StaffLastName);
            DB.AddParameter("StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("StaffPassword", mThisStaff.StaffPassword);
            DB.AddParameter("StaffDateJoined", mThisStaff.StaffDateJoined);
            DB.AddParameter("isManager", mThisStaff.StaffIsManager);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //deletes the record point to by ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("StaffID", mThisStaff.StaffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByLastName(string LastName)
        {
            //filters the records based on a full or partial Last Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Last Name parameter to the database
            DB.AddParameter("@LastName", LastName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByLastName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mStaffList = new List<clsStaff>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFirstName"]);
                AStaff.StaffLastName = Convert.ToString(DB.DataTable.Rows[Index]["StaffLastName"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AStaff.StaffDateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDateJoined"]);
                AStaff.StaffIsManager = Convert.ToBoolean(DB.DataTable.Rows[Index]["isManager"]);
                //add the record to the private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }

    }

}