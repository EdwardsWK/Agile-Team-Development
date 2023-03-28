using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Order_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        // Create an instance of the Order collection
        clsOrderCollection Orders = new clsOrderCollection();

        // Set the data source to the list of Orders in the collection
        lstOrderList.DataSource = Orders.OrderList;

        // Set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        
        // Set the data fields to display
        lstOrderList.DataTextField = "OrderPlaced";

        // Bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;

        // Redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Var to store the primary key value of the record to be edited
        Int32 OrderID;

        // If a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);

            // Store the data in the session object
            Session["OrderID"] = OrderID;

            // Redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        // If no record has been selected
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Var to store the primary key value of the record to be edited
        Int32 OrderID;

        // If a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);

            // Store the data in the session object
            Session["OrderID"] = OrderID;

            // Redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        // If no record has been selected
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}