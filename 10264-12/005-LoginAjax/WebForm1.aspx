<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_005_LoginAjax.WebForm1" %>

<%@ Register src="SM.ascx" tagname="SM" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="/Scripts/Verificar.js"></script>
</head>
<body onload="javascript:Verificar();">
    <form id="form1" runat="server">
    <uc1:SM ID="SM1" runat="server" />
    <div>
        <h1>
            Página principal</h1>
    </div>
    </form>
</body>
</html>
