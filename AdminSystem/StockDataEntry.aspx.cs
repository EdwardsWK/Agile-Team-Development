using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Stock_DataEntry : System.Web.UI.Page
{
    // Variable to store the primary key with page level scope

    Int32 ProductID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of products to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            // If this is not a new record
            if (ProductID != -1)
            {
                // Display the current data for that record
                DisplayProduct();
            }
        }

    }

    void DisplayProduct()
    {
        // Create an instance of the product list
        clsProductCollection productCollection = new clsProductCollection();

        // Find the record to update
        productCollection.ThisProduct.Find(ProductID);

        //Display the data for this record
        txtProductID.Text = productCollection.ThisProduct.ProductID.ToString();
        txtProductName.Text = productCollection.ThisProduct.ProductName;
        txtDateAdded.Text = productCollection.ThisProduct.DateAdded.ToString();
        txtStockCount.Text = productCollection.ThisProduct.StockCount.ToString();
        txtPrice.Text = productCollection.ThisProduct.Price.ToString();
        chkAvailable.Checked = productCollection.ThisProduct.Available;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {

        // Create a new instance of clsProduct
        clsProduct aProduct = new clsProduct();

        // Capture the ProductName
        string ProductName = txtProductName.Text;
        // Capture the DateAdded
        string DateAdded = txtDateAdded.Text;
        // Capture the StockCount
        string StockCount = txtStockCount.Text;
        // Capture the Price
        string Price = txtPrice.Text;

        // Variable for storing any error messages
        string Error = "";

        // Validate the data
        Error = aProduct.Valid(ProductName, DateAdded, StockCount, Price);
        if (Error == "")
        {
            // capture the data
            aProduct.ProductID = ProductID;
            aProduct.ProductName = ProductName;
            aProduct.DateAdded = Convert.ToDateTime(DateAdded);
            aProduct.StockCount = Convert.ToInt32(StockCount);
            aProduct.Price = (float)Convert.ToInt32(Price);
            aProduct.Available = chkAvailable.Checked;
            // Create a new instance of the product collection
            clsProductCollection productList = new clsProductCollection();

            // If this is a new record i.e. ProductID = -1 then add the data
            if (ProductID == -1)
            {
                // Set the thisProduct property
                productList.ThisProduct = aProduct;
                // Add the new record
                productList.Add();
            }
            else
            {
                // Find the record to update
                productList.ThisProduct.Find(ProductID);
                // Set the thisProduct property
                productList.ThisProduct = aProduct;
                // Update the record
                productList.Update();
            }
            // redirect back to the listpage
            Response.Redirect("StockList.aspx");
        }
        else
        {
            // Display the error message
            lblError.Text = Error;
        }
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}