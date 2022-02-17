<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="bookId" runat="server" Text="Book ID" width="99px"></asp:Label>
        <asp:TextBox ID="txtbookId" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="bookSearches" runat="server" Text="Genre &amp; Author"></asp:Label>
            <asp:TextBox ID="txtbookSearches" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="bookDescription" runat="server" Text="Title" width="99px"></asp:Label>
        <asp:TextBox ID="txtbookDescription" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="price" runat="server" Text="Price" width="99px"></asp:Label>
            <asp:TextBox ID="txtprice" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="dayAdded" runat="server" Text="Date Added" width="99px"></asp:Label>
        <asp:TextBox ID="txtdayAdded" runat="server"></asp:TextBox>
        <br />
        <p>
            <asp:CheckBox ID="chkavailable" runat="server" Text="Available" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="55px" />
&nbsp;
        <p>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
