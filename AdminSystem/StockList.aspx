<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_Stock_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 16px; top: 482px; position: absolute" Text="Enter a Product Name"></asp:Label>
            <asp:ListBox ID="lstProductList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 377px; width: 535px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 9px; top: 401px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 53px; top: 401px; position: absolute" Text="Update/Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 445px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 159px; top: 401px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 11px; top: 512px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 79px; top: 512px; position: absolute" Text="Clear" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 204px; top: 480px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
