using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Stock_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsProduct
        clsProduct aProduct = new clsProduct();

        // Get the data from the session object
        aProduct = (clsProduct)Session["aProduct"];

        // Display the product number for this entry
        Response.Write("Product ID: " + aProduct.ProductID + "\n");
        Response.Write("Product Name: " + aProduct.ProductName + "\r\n");
        Response.Write("Product Date Added: " + aProduct.DateAdded + "\r\n");
        Response.Write("Product Stock Count: " + aProduct.StockCount + "\r\n");
        Response.Write("Product Price: £" + aProduct.Price + "\r\n");
        Response.Write("Product Available: " + aProduct.Available + "\r\n");
    }
}