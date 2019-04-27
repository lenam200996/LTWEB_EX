<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau4.aspx.cs" Inherits="Cau4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        so luong
        <input id="soluong" type="text" /> don gia<input id="dongia" type="text" onkeyup="tinh()"/><br />
        <br />
        thanh tien
        <input id="thanhtien" type="text" /></div>
    </form>
    <script>

        function tinh() {
            document.getElementById("thanhtien").value = parseFloat(document.getElementById("soluong").value) * parseFloat(document.getElementById("dongia").value)
        }
    </script>
</body>
</html>
