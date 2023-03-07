using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Staff_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the data from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff details for this entry
        Response.Write("Staff ID " + AStaff.StaffID + "<br /> \n");
        Response.Write("Staff First Name " + AStaff.StaffFirstName + "<br /> \n");
        Response.Write("Staff Last Name " + AStaff.StaffLastName + "<br /> \n");
        Response.Write("Staff Email " + AStaff.StaffEmail + "<br /> \n");
        Response.Write("Staff Password " + AStaff.StaffPassword + "<br /> \n");
        Response.Write("Staff Date Joined " + AStaff.StaffDateJoined + "<br /> \n");
        Response.Write("Staff Is Manager " + AStaff.StaffIsManager + "<br /> \n");

    }
}