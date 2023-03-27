<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_Staff_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="frmStaff" runat="server">
        <div>
            <h3>Staff Data Entry</h3>
            <asp:Label ID="lblStaffID" runat="server" Text="Staff ID " width="175px"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name " width="175px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name " width="175px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email " width="175px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl1Password" runat="server" Text="Password " width="175px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateJoined" runat="server" Text="Start Date " width="175px"></asp:Label>
            <asp:TextBox ID="txtStaffDateJoined" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblIsManager" runat="server" Text="Is Manager? "></asp:Label>
            <asp:CheckBox ID="chkIsManager" runat="server" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
