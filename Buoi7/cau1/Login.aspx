<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style8 {
        width: 99px;
    }
    .auto-style9 {
        width: 99px;
        height: 23px;
    }
    .auto-style10 {
        height: 23px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style9">Tài Khoản</td>
        <td class="auto-style10">
            <asp:TextBox ID="txtTaiKhoan" runat="server" Width="227px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Mật Khẩu</td>
        <td style="width: 50%;">
            <asp:TextBox ID="txtMatKhau" runat="server" Width="227px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" style="text-align: center;">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Đăng nhập" />
        </td>
    </tr>
</table>
</asp:Content>

