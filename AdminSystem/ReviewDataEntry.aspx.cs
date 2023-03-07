using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Review_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsReview
        clsReview AReview = new clsReview();
        // Capture the review details
        AReview.ReviewID = Convert.ToInt32(txtReviewID.Text);
        AReview.ProductID = Convert.ToInt32(txtProductID.Text);
        AReview.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AReview.ReviewDate = Convert.ToDateTime(txtReviewDate.Text);
        AReview.Comments = txtComments.Text;
        AReview.Rating = Convert.ToInt32(txtRating.Text);
        AReview.Approved = chkApproved.Checked;
        // Store the review details in the session object
        Session["AReview"] = AReview;
        // Navigate to the viewer page
        Response.Redirect("ReviewViewer.aspx");
    }
}