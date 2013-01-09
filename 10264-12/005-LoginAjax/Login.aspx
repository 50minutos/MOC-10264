<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_005_LoginAjax.Login" %>

<%@ Register Src="SM.ascx" TagName="SM" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="/Scripts/Logar.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:SM ID="SM1" runat="server" />
    <div>
        <p>
            Nome:
            <asp:TextBox ID="TextBox1" runat="server" /></p>
        <p>
            Senha:
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" /></p>
        <p>
            <input type="button" value="Logar" onclick="javascript:Logar(TextBox1.value, TextBox2.value)" /></p>
    </div>
    </form>
</body>
</html>
