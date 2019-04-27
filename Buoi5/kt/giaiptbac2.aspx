<%@ Page Language="C#" AutoEventWireup="true" CodeFile="giaiptbac2.aspx.cs" Inherits="kt_giaiptbac2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        x^2 +
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        x +
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;= 0
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="giai" />
        <br />
        x1 = <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        x2 =
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
