<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="lblOrderID" runat="server" Text="Order Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <br />
            <asp:Label ID="lblOrderSearch" runat="server" Text="Search Order" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderSearch" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDelivery" runat="server" Text="Delivery" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderDelivery" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderAddress" runat="server" Text="Address" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderAddress" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderReturn" runat="server" Text="Return Address" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Date" width="91px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="ChkActive" runat="server" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" style="height: 26px" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
