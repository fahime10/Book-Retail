<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID" width="82px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server" Width="156px" Height="22px"></asp:TextBox>
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="lblUnitQuantity" runat="server" Text="Unit Quantity" width="82px"></asp:Label>
            <asp:TextBox ID="txtUnitQuantity" runat="server" width="164px"></asp:TextBox>
        </p>
        <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="82px"></asp:Label>
        <asp:TextBox ID="txtTotalPrice" runat="server" width="164px"></asp:TextBox>
        <p>
            <asp:Label ID="lblShipAddress" runat="server" Text="Ship Address"></asp:Label>
            <asp:TextBox ID="txtShipAddress" runat="server" width="164px"></asp:TextBox>
        </p>
        <asp:Label ID="lblOrderPlacedDate" runat="server" Text="Order Date" width="82px"></asp:Label>
        <asp:TextBox ID="txtOrderPlacedDate" runat="server" width="164px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkStaff" runat="server" Text="Staff?" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
