<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau7.aspx.cs" Inherits="Cau7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        sdt
        <asp:TextBox ID="txtsdt" runat="server"></asp:TextBox>
&nbsp;<br />
        email
        <asp:TextBox ID="txtemail" runat="server" Width="129px"></asp:TextBox>
        <br />
        ngay thang
        <asp:TextBox ID="ngaythang" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="kiem tra" />
    
    </div>
        <asp:Label ID="txtthongbao" runat="server"></asp:Label>
    </form>
</body>
</html>
