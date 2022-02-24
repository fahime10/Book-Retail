<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="423px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" height="44px" style="margin-left: 41px; margin-top: 18px" width="365px"></asp:TextBox>
        </div>
        <asp:Label ID="lblCustomerFirstName" runat="server" Text="First Name" width="423px"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" height="44px" style="margin-left: 40px" width="365px"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerLastName" runat="server" Text="Last Name" width="423px"></asp:Label>
            <asp:TextBox ID="txtCustomerLastName" runat="server" height="44px" style="margin-left: 41px" width="365px"></asp:TextBox>
        </p>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" width="423px"></asp:Label>
        <asp:TextBox ID="txtCustomerAddress" runat="server" height="44px" style="margin-left: 43px" width="365px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerAccCreated" runat="server" Text="When account was created"></asp:Label>
        <asp:TextBox ID="txtCustomerAccCreated" runat="server" Height="44px" style="margin-left: 44px" width="365px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkExistingAcc" runat="server" OnCheckedChanged="chkExistingAcc_CheckedChanged" Text="Does Account Exist" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="margin-left: 0px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 29px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
