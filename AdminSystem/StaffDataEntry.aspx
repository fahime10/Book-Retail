<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 553px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffID" runat="server" Text="Staff ID" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffID" runat="server" Height="16px" Width="87px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" Text="Find" />
        <br />
        <br />
        <asp:Label ID="lblStaffFirstName" runat="server" Text="Staff First Name"></asp:Label>
        <asp:TextBox ID="txtStaffFirstName" runat="server" Width="172px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffLastName" runat="server" Text="Staff Last Name" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffEndDate" runat="server" Text="Staff End Date" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffEndDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStaffSalary" runat="server" Text="Staff Salary" width="100px"></asp:Label>
        <asp:TextBox ID="txtStaffSalary" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkStaffEmployed" runat="server" Text="Staff Employed" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
