﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_002_Route.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Resultado da pesquisa de clientes</h1>
        <p>
            Você pesquisou:
            <asp:Label ID="TextoPesquisado" runat="server" Font-Bold="true" /></p>

            <%-- fancy url = url amigável --%>
    </div>
    </form>
</body>
</html>