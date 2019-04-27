<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau7.aspx.cs" Inherits="Cau7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        Day<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        Month<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        Yeah<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Display" />
        
    </div>
    </form>
</body>
</html>
