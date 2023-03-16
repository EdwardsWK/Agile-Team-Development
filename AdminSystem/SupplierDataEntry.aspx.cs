using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Supplier_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display the ID number for this entry
        Response.Write(AnSupplier.SupplierAddress);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        Session["AnSupplier"] = AnSupplier;

        // navigate to the viewer page
        Response.Redirect("SupplierViewer.aspx");
    }
}