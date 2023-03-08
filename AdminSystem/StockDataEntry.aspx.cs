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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the address class
        clsProduct Product = new clsProduct();
        // Variable to store the primary key
        Int32 ProductID;
        // Variable to store the result of the find operation
        Boolean Found = false;
        // Get the primary key entered by the user
        ProductID = Convert.ToInt32(txtProductID.Text);
        // Find the record
        Found = Product.Find(ProductID);
        // If found
        if (Found == true)
        {
            // Display the values of the properties in the form
            txtProductID.Text = Product.ProductID.ToString();
            txtProductName.Text = Product.ProductName;
            txtDateAdded.Text = Product.DateAdded.ToString();
            txtStockCount.Text = Product.StockCount.ToString();
            txtPrice.Text = Product.Price.ToString();
            chkAvailable.Checked = Product.Available; 

        }

    }
}