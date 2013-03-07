<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_SEO.WebForm1" %>

<%@ Register src="Menu.ascx" tagname="Menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>título da webform</title>
    <meta name="description" content="site com informações a respeito de tecnologias Microsoft" />
    <meta name="keyword" content="site exemplo, caso nardoni, visual studio, vs2010, cotação do dólar" />
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:Menu ID="Menu1" runat="server" />
    
    </div>
    <h1 class="style1">
        Página inicial do site</h1>
    <p class="style1">
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="http://www.google.com">Google</asp:HyperLink>
    </p>
    </form>
<%--google penaliza isso:--%>
    <p style="font-size:0px;">maçã, abóbora</p>
    <p style="color:#fff;">maçã, abóbora</p>
</body>
</html>
