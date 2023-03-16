<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_Supplier_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 24px; top: 411px; position: absolute" Text="OK" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 81px; top: 410px; position: absolute" Text="Cancel" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 179px; top: 236px; position: absolute" height="22px" width="123px"></asp:TextBox>
            <asp:Label ID="txtSupplierNumber" runat="server" style="z-index: 1; left: 26px; top: 241px; position: absolute" Text="Supplier Number" width="85px"></asp:Label>
            <asp:CheckBox ID="chkCurrentSupplier" runat="server" style="z-index: 1; left: 23px; top: 285px; position: absolute" Text="Current Supplier" width="85px" />
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 179px; top: 201px; position: absolute" height="22px" width="123px"></asp:TextBox>
            <asp:Label ID="txtEmailAddress" runat="server" style="z-index: 1; left: 27px; top: 206px; position: absolute" Text="Email Address" width="85px"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 329px; position: absolute" width="85px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 179px; top: 132px; position: absolute; margin-top: 2px" height="22px" width="123px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 179px; top: 166px; position: absolute; " height="22px" width="123px"></asp:TextBox>
            <asp:Label ID="txtContractDate" runat="server" style="z-index: 1; left: 26px; top: 167px; position: absolute" Text="Contract Date" width="85px"></asp:Label>
            <asp:Label ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 24px; top: 133px; position: absolute" Text="Supplier Address" width="85px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; top: 88px; position: absolute; bottom: 514px; left: 179px; margin-top: 5px; width: 123px;" height="22px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="txtSupplierID" runat="server" style="z-index: 1; left: 24px; top: 59px; position: absolute; bottom: 558px;" Text="SupplierID"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; top: 55px; position: absolute; left: 183px; margin-top: 0px; height: 20px; width: 123px;"></asp:TextBox>
        </p>
        <asp:Label ID="txtSupplierName" runat="server" style="z-index: 1; left: 26px; top: 75px; position: absolute; bottom: 534px; margin-top: 20px" Text="Supplier Name" width="85px"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
