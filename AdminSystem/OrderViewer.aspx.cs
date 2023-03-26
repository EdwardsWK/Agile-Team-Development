using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Order_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        
        // Get the data from the session object
        AnOrder = (clsOrder)Session["AnOrder"];
        
        // Display the order details for this entry
        Response.Write("Order Placed: " + AnOrder.OrderPlaced + "<br>\n");
        Response.Write("Customer ID: " + AnOrder.CustomerID + "<br>\n");
        Response.Write("Order Notes: " + AnOrder.OrderNotes + "<br>\n");
        Response.Write("Product ID: " + AnOrder.ProductID + "<br>\n");
        Response.Write("Order Total: " + AnOrder.OrderTotal + "<br>\n");
        Response.Write("Order Completed: " + AnOrder.OrderCompleted + "<br>\n");
    }
}