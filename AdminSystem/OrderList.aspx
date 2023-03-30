<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_Order_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order List</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="frmOrder" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" height="365px" width="310px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
            <p>
                <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            </p 
            <p>
                <asp:Label ID="lblFilter" runat="server">Enter a Product ID</asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
            </p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
