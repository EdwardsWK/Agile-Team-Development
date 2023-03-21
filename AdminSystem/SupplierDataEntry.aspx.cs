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
        ASupplier.TelephoneNo = txtTelephoneNo.Text;
        ASupplier.CurrentSupplier = chkCurrentSupplier.Checked;
        // Store the supplier details in the session object
        Session["ASupplier"] = ASupplier;
        // Navigate to the viewer page 
        Response.Redirect("SupplierViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Supplier class
        clsSupplier ASupplier = new clsSupplier();

        // Variable to store the primary key
        Int32 SupplierID;

        // Variable to store the result of the find operation
        Boolean Found = false;

        // Get the primary key entered by the user
        SupplierID = Convert.ToInt32(txtSupplierID.Text);

        // Find the record
        Found = ASupplier.Find(SupplierID);

        if (Found == true)
        {
            txtSupplierName.Text = ASupplier.SupplierName;
            txtSupplierAddress.Text = ASupplier.SupplierAddress;
            txtContractDate.Text = ASupplier.ContractDate.ToShortDateString();
            txtEmailAddress.Text = ASupplier.EmailAddress;
            txtTelephoneNo.Text = ASupplier.TelephoneNo;
            chkCurrentSupplier.Checked = ASupplier.CurrentSupplier;
        }
    }
}