<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_005_Cookie.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Cookie</h1>
    <p>
        Nome:<br />
        <asp:TextBox runat="server" ID="Nome"></asp:TextBox>
    </p>
    <p>
        <asp:Button runat="server" Text="Clique aqui" OnClick="Clique" />
    </p>
    </div>
    </form>
</body>
</html>
