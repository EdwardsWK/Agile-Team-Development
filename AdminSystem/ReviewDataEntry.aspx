<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewDataEntry.aspx.cs" Inherits="_Review_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ReviewOrderNo</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body id="IdReviewNo">
    <form id="form1" runat="server">
        <asp:Label ID="lblReviewID" runat="server" Text="Review ID " width="275px"></asp:Label>
        <asp:TextBox ID="txtReviewID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="IdProductno" runat="server"  Text="ProductId" width="275px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="IdCustomer" runat="server"  Text="CustomerID" width="275px"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="IdLabel" runat="server" Text="LabelReviewDate"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="IdRating" runat="server"  Text="RatingId" width="275px"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="IdComment" runat="server"  Text="Comment" width="275px"></asp:Label>
        <asp:TextBox ID="TextBox7" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="IdApproved" runat="server" Text="ApprovedId" width="275px"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox>
    </form>
</body>
</html>
