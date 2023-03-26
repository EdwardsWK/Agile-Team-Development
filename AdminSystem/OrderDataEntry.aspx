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
            <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 10px; top: 66px; height: 15px; position: absolute;" Text="Order ID" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 195px; top: 66px; height: 15px; position: absolute;" Width="160px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click"  style="z-index: 1; left: 375px; top: 66px; height: 20px; position: absolute;" Text="Find" />
            <br />
            <asp:Label ID="lblOrderPlaced" runat="server" style="z-index: 1; left: 10px; top: 88px; height: 15px; position: absolute;" Text="Order Placed" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderPlaced" runat="server" style="z-index: 1; left: 195px; top: 88px; height: 15px; position: absolute;" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 110px; height: 15px; position: absolute;" Text="Customer ID" width="185px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 195px; top: 110px; height: 15px; position: absolute;" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderNotes" runat="server" style="z-index: 1; left: 10px; top: 133px; height: 15px; position: absolute;" Text="Order Notes" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderNotes" runat="server" style="z-index: 1; left: 195px; top: 133px; height: 15px; position: absolute;" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 155px; height: 15px; position: absolute;" Text="Product ID" width="185px"></asp:Label>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 195px; top: 155px; height: 15px; position: absolute;" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderTotal" runat="server" style="z-index: 1; left: 10px; top: 177px; height: 15px; position: absolute;" Text="Order Total" width="185px"></asp:Label>
            <asp:TextBox ID="txtOrderTotal" runat="server" style="z-index: 1; left: 195px; top: 177px; height: 15px; position: absolute;" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderCompleted" runat="server" style="z-index: 1; left: 10px; top: 199px; height: 15px; position: absolute;" Text="Order Completed?" width="185px"></asp:Label>
            <asp:CheckBox ID="chkOrderCompleted" runat="server" style="z-index: 1; left: 195px; top: 199px; height: 15px; position: absolute;" Width="160px" />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 221px; height: 15px; position: absolute;"></asp:Label>
            <br />
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" style="z-index: 1; left: 10px; top: 243px; height: 20px; position: absolute;" Text="Confirm" Width="62px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 78px; top: 243px; height: 20px; position: absolute;" Text="Cancel" Width="57px" />
        </div>
    </form>
</body>
</html>
