using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Order_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        
        // Capture the order details
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        AnOrder.OrderPlaced = Convert.ToDateTime(txtOrderPlaced.Text);
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnOrder.OrderNotes = txtOrderNotes.Text;
        AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
        AnOrder.OrderTotal = Convert.ToDouble(txtOrderTotal.Text);
        AnOrder.OrderCompleted = chkOrderCompleted.Checked;
        
        // Store the order details in the session object
        Session["AnOrder"] = AnOrder;
        
        // Navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Order class
        clsOrder AnOrder = new clsOrder();

        // Variable to store the primary key
        Int32 OrderID;

        // Variable to store the result of the find operation
        Boolean Found = false;

        // Get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);

        // Find the record
        Found = AnOrder.Find(OrderID);

        if (Found == true)
        {
            txtOrderPlaced.Text = AnOrder.OrderPlaced.ToString();
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderNotes.Text = AnOrder.OrderNotes;
            txtProductID.Text = AnOrder.ProductID.ToString();
            txtOrderTotal.Text = AnOrder.OrderTotal.ToString();
            chkOrderCompleted.Checked = AnOrder.OrderCompleted;
        }
    }
}