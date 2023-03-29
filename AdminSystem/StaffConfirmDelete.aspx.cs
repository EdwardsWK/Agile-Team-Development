using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Staff_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the Staff class
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to delete
        Staff.ThisStaff.Find(StaffID);
        //delete the record
        Staff.Delete();
        //redirect back to the main page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the StaffList page
        Response.Redirect("StaffList.aspx");
    }
}