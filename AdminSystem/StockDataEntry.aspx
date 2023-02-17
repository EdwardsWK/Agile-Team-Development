<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_Stock_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ProductID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; bottom: 643px" Text="ProductID"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 118px; top: 14px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="StockCount" runat="server" style="z-index: 1; left: 10px; top: 75px; position: absolute" Text="StockCount" width="64px"></asp:Label>
        <asp:Label ID="DateAdded" runat="server" style="z-index: 1; left: 10px; top: 54px; position: absolute" Text="DateAdded" width="64px"></asp:Label>
        <asp:Label ID="ProductName" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="ProductName" width="64px"></asp:Label>
        <asp:Label ID="Price" runat="server" style="z-index: 1; left: 9px; top: 95px; position: absolute; height: 19px" Text="Price" width="64px"></asp:Label>
        <asp:Label ID="Available" runat="server" style="z-index: 1; left: 10px; top: 115px; position: absolute" Text="Available" width="64px"></asp:Label>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 118px; top: 33px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 118px; top: 51px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtStockCount" runat="server" style="z-index: 1; left: 118px; top: 72px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 118px; top: 92px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 118px; top: 115px; position: absolute" Text="Tick for True | Leave unticked for false" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 11px; top: 155px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 70px; top: 156px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
