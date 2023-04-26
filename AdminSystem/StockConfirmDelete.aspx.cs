using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Stock_ConfirmDelete : System.Web.UI.Page
{
    // Variable to store the primary key value of the record to be deleted
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the address to be deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the product collection class
        clsProductCollection product = new clsProductCollection();
        //find the record to delete
        product.ThisProduct.Find(ProductID);
        //delete the record
        product.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect to the StockList page
        Response.Redirect("StockList.aspx");
    }
}