<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_002_LoginSession.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Login</h1>
        <p>
            Nome:<br />
            <asp:TextBox runat="server" ID="Nome" /></p>
        <p>
            Senha:<br />
            <asp:TextBox runat="server" ID="Senha" TextMode="Password" /></p>
        <p>
            <asp:Button Text="Clique aqui para logar" runat="server" 
                onclick="Unnamed1_Click" />
        </p>
    </div>
    </form>
</body>
</html>
