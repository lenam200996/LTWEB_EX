<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau2.aspx.cs" Inherits="Cau2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="width: 19px" Text="*" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="^" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        =<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
