<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_002_ServerSideControlComClientSideScript.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            <asp:Button ID="Button1" Text="clique aqui" runat="server" OnClientClick="javascript:alert('O avião... o avião... o avião...')" /></p>
        <p>
            <asp:Button ID="Button2" Text="clique aqui" runat="server" OnClientClick="javascript:alert('O avião... o avião... o avião...');return false;" /></p>
    </div>
    </form>
</body>
</html>
