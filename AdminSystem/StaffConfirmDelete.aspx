﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_Staff_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirmation" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <p>
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
            </p>
        </div>
    </form>
</body>
</html>
