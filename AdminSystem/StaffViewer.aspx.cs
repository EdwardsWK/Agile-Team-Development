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
        Response.Write("Staff ID: " + AStaff.StaffID + "<br /> \n");
        Response.Write("First Name: " + AStaff.StaffFirstName + "<br /> \n");
        Response.Write("Last Name: " + AStaff.StaffLastName + "<br /> \n");
        Response.Write("Email: " + AStaff.StaffEmail + "<br /> \n");
        Response.Write("Password: " + AStaff.StaffPassword + "<br /> \n");
        Response.Write("Date Joined: " + AStaff.StaffDateJoined + "<br /> \n");
        Response.Write("Is Manager: " + AStaff.StaffIsManager + "<br /> \n");
    }
}