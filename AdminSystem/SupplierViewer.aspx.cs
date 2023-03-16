using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ClassLibrary;

public partial class _Supplier_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        // Get the data from the session object
        ASupplier = (clsSupplier)Session["ASupplier"];
        // Display the Supplier details for this entry
        Response.Write("Supplier ID: " + ASupplier.SupplierID + "<br>\n");
        Response.Write("Supplier Name: " + ASupplier.SupplierName + "<br>\n");
        Response.Write("Supplier Address: " + ASupplier.SupplierAddress + "<br>\n");
        Response.Write("Date Contracted: " + ASupplier.ContractDate + "<br>\n");
        Response.Write("Email Address: " + ASupplier.EmailAddress + "<br>\n");
        Response.Write("Supplier Number: " + ASupplier.SupplierNumber + "<br>\n");
        Response.Write("Current Supplier: " + ASupplier.CurrentSupplier + "<br>\n");
    }
}