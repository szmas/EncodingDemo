<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendParameter.aspx.cs"
    Inherits="EncodingDemo.SendParameter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="get" action="GetParameter.aspx">
    <div>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="传参" />
        <a href="GetParameter.aspx?name=张三丰">中文传参</a>
    </div>
    </form>
    <form method="get" action="GetParameter.aspx">
    <input type="text" name="name" id="Jname" />
    <input type="submit" name="btn" value="传参" />
    <input type="button" id="btnSubmit" value="JS传参" />
    </form>

    <form method="post">
    <input type="text" name="name" id="Text1" />
    <input type="submit" name="btn" value="传参" />
    </form>
    <script>

        window.onload = function () {
            document.getElementById('btnSubmit').onclick = function () {

                window.location.href = "GetParameter.aspx?name=" + document.getElementById('Jname').value;
            }
        }

    </script>
</body>
</html>
