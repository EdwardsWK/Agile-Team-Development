<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_Order_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Data Entry</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="frmOrder" runat="server">
        <div>
            <h3>Order Data Entry</h3>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID" height="25px" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderPlaced" runat="server" Text="Order Placed" height="25px" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderPlaced" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" height="25px" width="185px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderNotes" runat="server" Text="Order Notes" height="25px" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderNotes" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductID" runat="server" Text="Product ID" height="25px" width="185px"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderTotal" runat="server" Text="Order Total" height="25px" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderTotal" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderComplete" runat="server" Text="Order Completed?" height="25px" width="185px"></asp:Label>
            <asp:CheckBox ID="chkOrderComplete" runat="server" />
            <br />
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
