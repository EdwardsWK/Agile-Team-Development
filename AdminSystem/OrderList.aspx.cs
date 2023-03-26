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
        if (!IsPostBack)
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
}