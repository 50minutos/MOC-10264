<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_003_Resource.WebForm1" culture="auto" meta:resourcekey="Page" uiculture="auto" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><asp:Label ID="LabelEmpresa" runat="server" Text="<%$Resources:Strings, Empresa %>"/></p>
    
        <hr />
    
        <h1><asp:Label ID="LabelTitulo" runat="server" meta:resourcekey="LabelTitulo" /></h1>

        <p>
            <asp:Label ID="LabelNome" runat="server" meta:resourcekey="LabelNome" />
            <br/>
            <asp:TextBox ID="Nome" runat="server"/>
        </p>

        <p>
            <asp:Label ID="LabelSenha" runat="server" meta:resourcekey="LabelSenha" />
            <br/>
            <asp:TextBox ID="Senha" runat="server"/>
        </p>
    
        <p><asp:Button runat="server" meta:resourcekey="Button" /></p>
    
        <hr />

        <p><asp:Label ID="LabelEmail" runat="server" Text="<%$Resources:Strings, Email %>"/></p>
    </div>
    </form>
</body>
</html>
