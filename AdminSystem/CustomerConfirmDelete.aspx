<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 99px">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" style="margin-left: 5px" Text="No" OnClick="btnNo_Click" />
        </p>
    </form>
</body>
</html>
