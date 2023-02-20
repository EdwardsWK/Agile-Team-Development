using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Stock_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        // Create a new instance of clsProduct
        clsProduct aProduct = new clsProduct();
        // capture the productID 
        aProduct.ProductID = int.Parse(txtProductID.Text);
        aProduct.ProductName = txtProductName.Text;
        aProduct.DateAdded = DateTime.Parse(txtDateAdded.Text);
        aProduct.StockCount = int.Parse(txtStockCount.Text);
        aProduct.Price = float.Parse(txtPrice.Text);
        aProduct.Available = chkAvailable.Checked;

        // Store the Product Number in the Session Object
        Session["aProduct"] = aProduct;

        // Navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}