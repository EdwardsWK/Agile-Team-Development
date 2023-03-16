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

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsSupplier
        clsSupplier ASupplier = new clsSupplier();
        // Capture the supplier details
        ASupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        ASupplier.SupplierName = txtSupplierName.Text;
        ASupplier.SupplierAddress = txtSupplierAddress.Text;
        ASupplier.ContractDate = Convert.ToDateTime(txtContractDate.Text);
        ASupplier.EmailAddress = txtEmailAddress.Text;
        ASupplier.SupplierNumber = Convert.ToInt32(txtSupplierNumber.Text);
        ASupplier.CurrentSupplier = chkCurrentSupplier.Checked;
        // Store the supplier details in the session object
        Session["ASupplier"] = ASupplier;
        // Navigate to the viewer page 
        Response.Redirect("SupplierViewer.aspx");
    }
}