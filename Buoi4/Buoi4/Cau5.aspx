<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cau5.aspx.cs" Inherits="Cau5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <img  src="anh2.jpg" width="300px" height="500px" 
            onmouseout="mouseOver(this)" onclick="mouseDown(this)" 
            onmouseenter="mouseMove(this)"
            />
      
    </div>
    </form>

    <script>
        function mouseMove(anh) {
            anh.src = "anh1.png";
        }
        function mouseOver(anh) {
            anh.src = "anh3.jpg";
        }
        function mouseDown(anh) {
            anh.src = "anh4.jpg";
        }
    </script>
</body>
</html>
