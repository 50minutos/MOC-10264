<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_002_WebForms.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Código:
            <br />
            <asp:TextBox ID="CustomerID" runat="server" />
        </p>
        <p>
            <asp:Button Text="Clique aqui para pesquisar" runat="server" /></p>
        <h1>
            <asp:Label ID="FirstName" runat="server" /></h1>
    </div>
    </form>
</body>
</html>
