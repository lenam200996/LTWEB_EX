﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau1.aspx.cs" Inherits="Cau1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" Width="89px"></asp:TextBox>
        +<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        =<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tinh Tong" />
    
    </div>
    </form>
</body>
</html>
