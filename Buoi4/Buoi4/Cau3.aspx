<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau3.aspx.cs" Inherits="Cau3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input type="button" onclick="setColor('blue')" value="Blue" />
        <input type="button" onclick="setColor('red')" value="Red"/>
        <input type="button" onclick="setColor('yellow')" value="yellow"/>
    
    </div>
    </form>

    <script>
        function setColor(color) {
            document.getElementsByTagName("body")[0].style.backgroundColor = color;
        }
    </script>
</body>
</html>
