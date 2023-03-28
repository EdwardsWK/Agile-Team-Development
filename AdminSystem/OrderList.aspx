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
            <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 365px; width: 520px;" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 390px; position: absolute; width: 43px;" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" style="z-index: 1; left: 58px; top: 390px; position: absolute" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 420px; position: absolute"></asp:Label>
    </form>
</body>
</html>
