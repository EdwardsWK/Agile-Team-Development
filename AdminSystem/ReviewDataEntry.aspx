<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewDataEntry.aspx.cs" Inherits="_Review_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ReviewOrderNo</title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body id="IdReviewNo">
    <form id="form1" runat="server">
        <asp:Label ID="lblReviewID" runat="server" Text="Review ID "></asp:Label>
        <asp:TextBox ID="txtReviewID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbReviewNo" runat="server"  Text="ReviewOrderNo"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="IdProductno" runat="server"  Text="ProductId"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="IdCustomer" runat="server"  Text="CustomerID"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="IdLabel" runat="server" Text="LabelReviewDate"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox>
    </form>
</body>
</html>
