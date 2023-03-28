using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Order_ConfirmDelete : System.Web.UI.Page
{
    //. Var to store the primary key value of the record to be deleted
    Int32 OrderID;

    // Event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the ID of the Order to be deleted from the session
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Create a new instance of the OrderCollection class
        clsOrderCollection Order = new clsOrderCollection();

        // Find the record to delete
        Order.ThisOrder.Find(OrderID);

        // Delete the record
        Order.Delete();

        // Redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // Redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}