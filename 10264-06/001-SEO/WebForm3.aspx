<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_001_SEO.WebForm3" %>

<%@ Register Src="Menu.ascx" TagName="Menu" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>título da webform</title>
    <meta name="description" content="site com informações a respeito de tecnologias Microsoft" />
    <meta name="keyword" content="site exemplo, caso nardoni, visual studio, vs2010, cotação do dólar" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Menu ID="Menu1" runat="server" />
    </div>
    </form>
</body>
</html>
