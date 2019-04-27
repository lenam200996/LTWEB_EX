<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimKiemSinhVien.aspx.cs" Inherits="Cau2_ADO_TimKiemSinhVien" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Tim theo
        <asp:DropDownList ID="drtimtheo" runat="server">
            <asp:ListItem Value="masv">Ma Sinh Vien</asp:ListItem>
            <asp:ListItem Value="hotensv">Ho Ten SV</asp:ListItem>
        </asp:DropDownList>
&nbsp;Noi dung tim
        <asp:TextBox ID="txtnoidungtim" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" />
    
    </div>
        <p>
            &nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="MaSV" HeaderText="Ma SV" />
                <asp:BoundField DataField="HoTen" HeaderText="Ho Va Ten" />
                <asp:BoundField DataField="TenKhoa" HeaderText="TenKhoa" />
                <asp:ButtonField CommandName="chitiet" HeaderText="Chi Tiet" Text="Chi Tiet" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
