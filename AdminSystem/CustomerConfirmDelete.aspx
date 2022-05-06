<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?</div>
        <p>
            <asp:Button ID="btnYesDelete" runat="server" OnClick="btnYesDelete_Click" Text="Yes" />
            <asp:Button ID="btnNoDelete" runat="server" OnClick="btnNoDelete_Click" Text="No" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
