<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_Supplier_DataEntry" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="frmStock" runat="server">
        <div>
            <h3>Supplier Data Entry</h3>
            <asp:Label ID="lblSupplierID" runat="server" Text="Supplier ID" width="200px"></asp:Label>
            <asp:TextBox ID="txtSupplierID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name" width="200px"></asp:Label>
            <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierAddress" runat="server" Text="Supplier Address" width="200px"></asp:Label>
            <asp:TextBox ID="txtSupplierAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblContractDate" runat="server" Text="Date Contracted" width="200px"></asp:Label>
            <asp:TextBox ID="txtContractDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" width="200px"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblSupplierNumber" runat="server" Text="Telephone Number" width="200px"></asp:Label>
            <asp:TextBox ID="txtSupplierNumber" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCurrentSupplier" runat="server" Text="Current Supplier?" width="200px"></asp:Label>
            <asp:CheckBox ID="chkCurrentSupplier" runat="server" />
            <br />
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>