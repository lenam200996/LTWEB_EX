<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DangNhap.aspx.cs" Inherits="Cau1_LINQ_DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 25px;
        }
        .auto-style1 {
            width: 115px;
        }
        </style>
</head>
<body>
    <form id="form2" runat="server">
    <div>
    
        <table style="width: 100%; margin-left: 0px;">
            <tr>
                <td class="auto-style2" colspan="2" style="text-align: center;">ĐĂNG NHẬP</td>
            </tr>
            <tr>
                <td class="auto-style2">Tài Khoản</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtUs" runat="server" Width="246px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Mật Khẩu</td>
                <td>
                    <asp:TextBox ID="txtPw" runat="server" Width="242px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnDangNhap" runat="server" OnClick="btnDangNhap_Click" Text="Đăng Nhập" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
   
</body>
</html>
