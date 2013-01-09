<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_HandlerPng.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <th>link para download</th>
                <th>preview</th>
            </tr>
            <tr>
                <td><a href="Images/imagem1.png">imagem1.png</a></td>
                <td><img src="Images/imagem1.png" width="100" /></td>
            </tr>
            <tr>
                <td><a href="Download.ashx?NOME=Images/imagem2.png">imagem2.png</a></td>
                <td><img src="Images/imagem2.png" width="100" /></td>
            </tr>
            <tr>
                <td><a href="Download.ashx?NOME=Images/imagem3.png">imagem3.png</a></td>
                <td><img src="Images/imagem3.png" width="100" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
