using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Review_Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsReview
        clsReview AReview = new clsReview();
        // Get the data from the session object
        AReview = (clsReview)Session["AReview"];
        // Display the review details for this entry
        Response.Write("Review ID: " + AReview.ReviewID + "<br>\n");
        Response.Write("Product ID: " + AReview.ProductID + "<br>\n");
        Response.Write("Customer ID: " + AReview.CustomerID + "<br>\n");
        Response.Write("Review Date: " + AReview.ReviewDate + "<br>\n");
        Response.Write("Comments: " + AReview.Comments + "<br>\n");
        Response.Write("Rating: " + AReview.Rating + "<br>\n");
        Response.Write("Approved: " + AReview.Approved + "<br>\n");
    }
}