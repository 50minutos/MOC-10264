<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_Theme.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Título</h1>
        
        <p>parágrafo...</p>
        <p class="centro">parágrafo centralizado...</p>
        <p class="direita">outro parágrafo</p>
        <p><asp:Label ID="Label1" runat="server">alguma coisa está escrita aqui...</asp:Label></p>
        <p><asp:Label ID="Label2" runat="server" SkinID="LabelBranco">OUTRA coisa aqui...</asp:Label></p>
        <p>
            <asp:DropDownList ID="DDL" runat="server" AutoPostBack="True" OnSelectedIndexChanged="TrocarTheme">
                <asp:ListItem Text="Amarelo" />
                <asp:ListItem Text="Cinza" />
            </asp:DropDownList>
        </p>

    </div>
    </form>
</body>
</html>
