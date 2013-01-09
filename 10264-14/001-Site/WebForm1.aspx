<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_Site.WebForm1" %>

<%@ Register src="Menu.ascx" tagname="Menu" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1 {
            width: 256px;
            height: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <uc1:Menu ID="Menu1" runat="server" />
       Página 1
        <br />
        <img alt="" class="style1" src="Imagens/Jellyfish.jpg" /></div>
    </form>
</body>
</html>
