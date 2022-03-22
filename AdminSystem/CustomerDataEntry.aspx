<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblcustomerNo" runat="server" Text="Customer Number" width="160px" height="22px"></asp:Label>
            <asp:TextBox ID="txtcustomerNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" height="22px" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="customerName" runat="server" Text="Name" width="160px"></asp:Label>
        <asp:TextBox ID="txtcustomerName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="customerAddress" runat="server" Text="Address" Width="160px"></asp:Label>
            <asp:TextBox ID="txtcustomerAddress" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="hasAccount" runat="server" Text="Account Status" width="160px"></asp:Label>
        <asp:CheckBox ID="chkhasAccount" runat="server" Text="Active" EnableViewState="False" />
        <p>
            <asp:Label ID="creationDate" runat="server" Text="Date of Account Creation" width="160px"></asp:Label>
            <asp:TextBox ID="txtCreationDate" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
