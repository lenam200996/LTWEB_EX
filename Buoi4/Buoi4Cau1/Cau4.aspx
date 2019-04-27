<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau4.aspx.cs" Inherits="Cau4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <select id="Select1" onchange="setColor()">
            <option value="red">Red</option>
            <option value="blue">Blue</option>
            <option value="brown">Brown</option>
            <option value="lavender">Lavender</option>
        </select>
    </div>
    </form>

    <script>
        function setColor() {
            document.getElementsByTagName("body")[0].style.backgroundColor = document.getElementById("Select1").value;
        }
    </script>
</body>
</html>
