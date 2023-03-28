using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Staff_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the ID to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff First Name
        string StaffFirstName = txtFirstName.Text;
        //capture the staff Last Name
        string StaffLastName = txtLastName.Text;
        //capture the staff Email
        string StaffEmail = txtEmail.Text;
        //capture the staff Password
        string StaffPassword = txtPassword.Text;
        //capture the staff Date Joined
        string StaffDateJoined = txtStaffDateJoined.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffEmail, StaffPassword, StaffDateJoined);
        if (Error == "")
        {
            //capture the staff ID
            AStaff.StaffID = StaffID;
            //capture the staff First Name
            AStaff.StaffFirstName = StaffFirstName;
            //capture the staff Last Name
            AStaff.StaffLastName = StaffLastName;
            //capture the staff Email
            AStaff.StaffEmail = StaffEmail;
            //capture the staff Password
            AStaff.StaffPassword = StaffPassword;
            //capture the staff Date Joined
            AStaff.StaffDateJoined = Convert.ToDateTime(StaffDateJoined);
            //capture if Staff is a Manager or not
            AStaff.StaffIsManager = chkIsManager.Checked;
            //create a new instance of the Staff Collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID = -1, then add the data
            if (StaffID == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffID);
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;
                //update the record
                StaffList.Update();
            }
            
            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the StaffID class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStaffID.Text = AStaff.StaffID.ToString();
            txtFirstName.Text = AStaff.StaffFirstName;
            txtLastName.Text = AStaff.StaffLastName;
            txtEmail.Text = AStaff.StaffEmail;
            txtPassword.Text = AStaff.StaffPassword;
            txtStaffDateJoined.Text = AStaff.StaffDateJoined.ToShortDateString();
            chkIsManager.Checked = AStaff.StaffIsManager;

        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //get the details for the staff
        Staff.ThisStaff.Find(StaffID);

        //set the data source to list of Staff in the collection
        txtStaffID.Text = Staff.ThisStaff.StaffID.ToString();
        txtFirstName.Text = Staff.ThisStaff.StaffFirstName;
        txtLastName.Text = Staff.ThisStaff.StaffLastName;
        txtEmail.Text = Staff.ThisStaff.StaffEmail;
        txtPassword.Text = Staff.ThisStaff.StaffPassword;
        txtStaffDateJoined.Text = Staff.ThisStaff.StaffDateJoined.ToString();
        chkIsManager.Checked = Staff.ThisStaff.StaffIsManager;
    }
}
