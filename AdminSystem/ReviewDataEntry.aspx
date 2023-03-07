<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewDataEntry.aspx.cs" Inherits="_Review_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Review Data Entry</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="frmReview" runat="server">
        <div>
            <h3>Review Data Entry</h3>
            <asp:Label ID="lblReviewID" runat="server" Text="Review ID " width="136px"></asp:Label>
            <asp:TextBox ID="txtReviewID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductID" runat="server"  Text="Product ID " width="136px"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerID" runat="server"  Text="Customer ID " width="136px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblReviewDate" runat="server" Text="Review Date " width="136px"></asp:Label>
            <asp:TextBox ID="txtReviewDate" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblComments" runat="server"  Text="Comments " width="136px"></asp:Label>
            <asp:TextBox ID="txtComments" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblRating" runat="server"  Text="Rating " width="136px"></asp:Label>
            <asp:TextBox ID="txtRating" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblApproved" runat="server" Text="Approved" width="136px"></asp:Label>
            <asp:CheckBox ID="chkApproved" runat="server" />
            <br />
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
