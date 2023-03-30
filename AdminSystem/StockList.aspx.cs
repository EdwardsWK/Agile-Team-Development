using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Stock_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // update the list
            DisplayProducts();
        }
    }

    void DisplayProducts()
    {
        // Create an instance of the Product collection
        clsProductCollection Products = new clsProductCollection();

        // Set the data source to list of products in the collection
        lstProductList.DataSource = Products.productList;

        // Set the name of the primary key
        lstProductList.DataValueField = "ProductID";

        // Set the data field to display
        lstProductList.DataTextField = "DateAdded";

        // Bind the data to the list
        lstProductList.DataBind();
    }
}