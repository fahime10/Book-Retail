<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblBookId" runat="server" Text="Book ID"></asp:Label>
            <asp:TextBox ID="txtBookId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblBookTitle" runat="server" Text="Title" width="54px"></asp:Label>
            <asp:TextBox ID="txtBookTitle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblBookPrice" runat="server" Text="Price" width="54px"></asp:Label>
            <asp:TextBox ID="txtBookPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblBookQuantity" runat="server" Text="Quantity" width="54px"></asp:Label>
            <asp:TextBox ID="txtBookQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateReceived" runat="server" Text="Date Received" width="54px"></asp:Label>
            <asp:TextBox ID="txtDateReceived" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkBookAvailability" runat="server" Text="Available" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
