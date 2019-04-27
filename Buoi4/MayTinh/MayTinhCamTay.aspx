<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MayTinhCamTay.aspx.cs" Inherits="MayTinhCamTay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Máy Tính Cầm Tay&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="txtOp" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="txtNhapPhepTinh" runat="server" OnTextChanged="txtNhapPhepTinh_TextChanged" Width="200px"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtkq" runat="server" Width="200px"></asp:TextBox>
        <br />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="100px" />
        <asp:Button ID="btnbang" runat="server" OnClick="btnbang_Click" Text="=" Width="100px" />
        <br />
        <asp:Button ID="btnNum1" runat="server" OnClick="btnNum1_Click" Text="1" Width="50px" />
        <asp:Button ID="btnNum2" runat="server" OnClick="btnNum2_Click" Text="2" Width="50px" />
        <asp:Button ID="btnNum3" runat="server" OnClick="btnNum3_Click" Text="3" Width="50px" />
        <asp:Button ID="btncong" runat="server" OnClick="btncong_Click" Text="+" Width="50px" />
        <br />
        <asp:Button ID="btnNum4" runat="server" OnClick="btnNum4_Click" Text="4" Width="50px" />
        <asp:Button ID="btnNum5" runat="server" OnClick="btnNum5_Click" Text="5" Width="50px" />
        <asp:Button ID="btnNum6" runat="server" OnClick="btnNum6_Click" Text="6" Width="50px" />
        <asp:Button ID="btnTru" runat="server" Height="26px" OnClick="btnTru_Click" Text="-" Width="50px" />
        <br />
        <asp:Button ID="btnNum7" runat="server" OnClick="btnNum7_Click" Text="7" Width="50px" />
        <asp:Button ID="btnNum8" runat="server" OnClick="btnNum8_Click" Text="8" Width="50px" />
        <asp:Button ID="btnNum9" runat="server" OnClick="btnNum9_Click" Text="9" Width="50px" />
        <asp:Button ID="btnnhan" runat="server" OnClick="btnnhan_Click" Text="*" Width="50px" />
        <br />
        <asp:Button ID="btnCham" runat="server" OnClick="btnCham_Click" Text="." Width="50px" />
        <asp:Button ID="btnNum0" runat="server" OnClick="btnNum0_Click" Text="0" Width="100px" />
        <asp:Button ID="btnchia" runat="server" OnClick="btnchia_Click" Text="/" Width="50px" />
    
    </div>
    </form>
</body>
</html>
