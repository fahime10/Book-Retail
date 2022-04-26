<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 527px;
        }
    </style>
</head>
<body style="height: 526px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="371px" Width="511px"> </asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter First Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
