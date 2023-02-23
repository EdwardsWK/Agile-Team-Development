<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_Staff_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Staff Detail Input"></asp:Label>
            <br />
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID   "></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name   "></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name   "></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email   "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl1Password" runat="server" Text="Password   "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateJoined" runat="server" Text="Start Date   "></asp:Label>
        <asp:TextBox ID="txtStaffDateJoined" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblIsManager" runat="server" Text="Manager?   "></asp:Label>
        <asp:CheckBox ID="CheckBox1" runat="server" />
        <p>
            <asp:Button ID="btnConfirm" runat="server" OnClick="Button1_Click" Text="Confirm" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
