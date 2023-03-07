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


}