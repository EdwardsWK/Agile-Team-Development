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
        string OrderPlaced = txtOrderPlaced.Text;
        string CustomerID = txtCustomerID.Text;
        string OrderNotes = txtOrderNotes.Text;
        string ProductID = txtProductID.Text;
        string OrderTotal = txtOrderTotal.Text;

        // Variable to store any error messages
        string Error = "ERROR: ";

        // Validate the data
        Error = Error + AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
        if (Error == "")
        {
            // Store the Order Details
            AnOrder.OrderPlaced = Convert.ToDateTime(OrderPlaced);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.OrderNotes = OrderNotes;
            AnOrder.ProductID = Convert.ToInt32(ProductID);
            AnOrder.OrderTotal = Convert.ToDouble(OrderTotal);

            // Create an instance of the address collection
            clsOrderCollection OrderList = new clsOrderCollection();

            // Set the ThisOrder property
            OrderList.ThisOrder = AnOrder;

            // Add the new record
            OrderList.Add();

            // Redirect back to the list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
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