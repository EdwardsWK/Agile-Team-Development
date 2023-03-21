using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Staff_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff details
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.StaffFirstName = txtFirstName.Text;
        AStaff.StaffLastName = txtLastName.Text;
        AStaff.StaffEmail = txtEmail.Text;
        AStaff.StaffPassword = txtPassword.Text;
        AStaff.StaffDateJoined = Convert.ToDateTime(txtStaffDateJoined.Text);
        AStaff.StaffIsManager = chkIsManager.Checked;
        //Store the staff details in a session object
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");




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
}
