<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_Order_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Confirm Delete</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="frmOrder" runat="server">
        <div>
            <p>
                <asp:Label ID="lblConfirmMsg" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            </p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" height="30px" Width="40px" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" height="30px" width="40px" />
        </div>
    </form>
</body>
</html>
