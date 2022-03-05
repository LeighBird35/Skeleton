<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffNo" runat="server" Text="Staff Number:" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffDesc" runat="server" Text="Staff Description:" width="121px"></asp:Label>
            <asp:TextBox ID="txtStaffDesc" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffName" runat="server" Text="Staff Name:" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblStaffDob" runat="server" Text="Staff Date of birth:" width="121px"></asp:Label>
            <asp:TextBox ID="txtStaffDob" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffWage" runat="server" Text="Staff Wage:" width="121px"></asp:Label>
        <asp:TextBox ID="txtStaffWage" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkAvaliable" runat="server" Text="Avaliable" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
