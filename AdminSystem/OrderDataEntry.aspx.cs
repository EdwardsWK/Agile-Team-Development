using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Order_DataEntry : System.Web.UI.Page
{
    // Variable to store the primary key with page level scope
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the ID of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            // If this is not a new record
            if (OrderID != -1)
            {
                // Display the current data fror the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        // Create an instance of the Order collection
        clsOrderCollection Order = new clsOrderCollection();

        // Get the details for the chosen Order
        Order.ThisOrder.Find(OrderID);

        // Populate the form with the Order details
        txtOrderID.Text = Order.ThisOrder.OrderID.ToString();
        txtOrderPlaced.Text = Order.ThisOrder.OrderPlaced.ToString();
        txtCustomerID.Text = Order.ThisOrder.CustomerID.ToString();
        txtOrderNotes.Text = Order.ThisOrder.OrderNotes;
        txtProductID.Text = Order.ThisOrder.ProductID.ToString();
        txtOrderTotal.Text = Order.ThisOrder.OrderTotal.ToString();
        chkOrderCompleted.Checked = Order.ThisOrder.OrderCompleted;
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
        string Error = "";

        // Validate the data
        Error = AnOrder.Valid(OrderPlaced, CustomerID, OrderNotes, ProductID, OrderTotal);
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

            // If this is a new record then add the data
            if (OrderID == -1)
            {
                // Set the ThisOrderProperty
                OrderList.ThisOrder = AnOrder;

                // Add the new record
                OrderList.Add();
            }
            // Otherwise it must be an update
            else
            {
                // Find the record to update
                OrderList.ThisOrder.Find(OrderID);

                // Set the ThisOrder property
                OrderList.ThisOrder = AnOrder;

                // Update the record
                OrderList.Update();
            }

            // Redirect back to the list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error + " Total: " + OrderTotal;
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