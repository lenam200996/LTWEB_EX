<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau3.aspx.cs" Inherits="Cau3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 227px;
            height: 163px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        so ky tu da nhap
        <input id="txtkytu" type="text" /><br />
        <textarea id="txtnhap" cols="50" name="S1" rows="50" onkeyup="changetext()"></textarea></div>
    </form>

    <script>

        function changetext() {
            document.getElementById("txtkytu").value = document.getElementById("txtnhap").value.length > 10 ? "ban nhap qua so ky tu" : document.getElementById("txtnhap").value.length;
        }
    </script>
</body>
</html>
