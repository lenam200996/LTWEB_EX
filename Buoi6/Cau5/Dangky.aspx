<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dangky.aspx.cs" Inherits="Cau5_Dangky" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="DANG KY THANH VIEN"></asp:Label>
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Ten dang nhap</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Mat khau</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nhap lai mat khau</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Gioi tinh</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Nam" />
                    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Nu" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Ngay sinh</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">So thich</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="The thao" />
                    <br />
                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Mua sam" />
                    <br />
                    <asp:CheckBox ID="CheckBox3" runat="server" Text="Am nhac" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Dang ky" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Nhap lai" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
