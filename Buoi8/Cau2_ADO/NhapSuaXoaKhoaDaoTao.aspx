<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NhapSuaXoaKhoaDaoTao.aspx.cs" Inherits="Cau2_ADO_NhapSuaXoaKhoaDaoTao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td colspan="3">Nhap Sua Xoa Khoa Dao Tao</td>
            </tr>
            <tr>
                <td>Ma khoa</td>
                <td>
                    <asp:TextBox ID="txtMaKhoa" runat="server" ReadOnly="True" Width="198px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Ten khoa</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtTenKhoa" runat="server" Width="198px"></asp:TextBox>
                </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style1">So dien thoai</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSDT" runat="server" Width="195px"></asp:TextBox>
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Them moi" />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ghi" />
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
        </table>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" style="margin-top: 0px">
            <Columns>
                <asp:BoundField DataField="MaKhoa" HeaderText="Ma Khoa" />
                <asp:BoundField DataField="TenKhoa" HeaderText="Ten Khoa" />
                <asp:BoundField DataField="Phone" HeaderText="Dien Thoai" />
                <asp:ButtonField CommandName="edit" HeaderText="EDIT" Text="Edit" />
                <asp:ButtonField CommandName="delete" HeaderText="DELETE" Text="Delete" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
