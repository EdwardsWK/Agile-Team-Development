using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Staff_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        //create an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to list of address in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to dispay
        lstStaffList.DataTextField = "StaffFirstName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if not record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //if filter textbox is not empty
        if (txtFilter.Text != "")
        {
            //create an instance of the StaffCollection
            clsStaffCollection Staff = new clsStaffCollection();
            Staff.ReportByLastName(txtFilter.Text);
            lstStaffList.DataSource = Staff.StaffList;
            //set the name of the primary key
            lstStaffList.DataValueField = "StaffID";
            //set the data fields to display
            lstStaffList.DataTextField = "StaffFirstName";
            //bind the data to the list
            lstStaffList.DataBind();
        }
        //if filter textbox empty
        else
        {
            lblError.Text = "Please enter a last name";
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the StaffCollection
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ReportByLastName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data fields to display
        lstStaffList.DataTextField = "StaffFirstName";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}