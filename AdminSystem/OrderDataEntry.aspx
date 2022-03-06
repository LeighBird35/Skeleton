<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" height="22px" Text="Order Number" width="99px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderID" runat="server" style="margin-left: 17px" Width="127px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderSearch" runat="server" height="19px" Text="Order Search" width="100px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderSearch" runat="server" height="22px" style="margin-left: 18px" width="126px"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Label ID="lblOrderDelivery" runat="server" height="17px" Text="Delivery" width="104px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderDelivery" runat="server" height="22px" style="margin-left: 14px" width="125px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderAddress" runat="server" height="18px" Text="Address" width="117px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderAddress" runat="server" height="22px" style="margin-left: 0px" width="127px"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Label ID="lblOrderReturn" runat="server" height="25px" Text="Return Address" width="105px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderReturn" runat="server" height="22px" style="margin-left: 14px" width="126px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblOrderDate" runat="server" height="19px" Text="Date" width="113px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderDate" runat="server" height="22px" style="margin-left: 6px" width="128px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
