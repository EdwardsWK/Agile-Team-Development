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
        lstProductList.DataTextField = "ProductName";

        // Bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["ProductID"] = -1;

        // Redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 ProductID;

        // If a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            // Store the data in the session object
            Session["ProductID"] = ProductID;
            // Redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else // if no record is selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be deleted
        Int32 ProductID;

        // if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);

            // Store the data in the session object
            Session["ProductID"] = ProductID;

            // Redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            // Display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // Create an instance of the product collection
        clsProductCollection products = new clsProductCollection();
        products.ReportByProductName(txtFilter.Text);
        lstProductList.DataSource = products.productList;

        // Set the name of the primary key
        lstProductList.DataValueField = "ProductID";

        // Set the name of the field to display
        lstProductList.DataTextField = "ProductName";

        // Bind the data to the list 
        lstProductList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // Create an instance of the product collection
        clsProductCollection products = new clsProductCollection();
        products.ReportByProductName("");
        // clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstProductList.DataSource = products.productList;

        // Set the name of the primary key
        lstProductList.DataValueField = "ProductID";

        // Set the name of the field to display
        lstProductList.DataTextField = "ProductName";

        // Bind the data to the list 
        lstProductList.DataBind();

    }
}