<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_003_RotaCustomizada.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Pesquisa de produtos</h1>
        <p>Digite o nome do produto:
            <br />
            <asp:TextBox runat="server" ID="Nome"></asp:TextBox>
        </p>
        <p><asp:Button ID="Button1" Text="Pesquisar produto" runat="server" /></p>
        <hr />
        <h1>Pesquisa de CEPs</h1>
        <p>Digite o CEP:
            <br />
            <asp:TextBox runat="server" ID="Cep"></asp:TextBox>
        </p>
        <p><asp:Button ID="Button2" Text="Pesquisar CEP" runat="server" /></p>
        <hr />
        <p><asp:HyperLink ID="LinkProduto" runat="server" NavigateUrl="<%$RouteUrl:RouteName=PesquisaProdutosComCategoria, CATEGORIA=brinquedos, PRODUTO=bicicleta%>">bicicletas</asp:HyperLink></p>
    </div>
    </form>
</body>
</html>
