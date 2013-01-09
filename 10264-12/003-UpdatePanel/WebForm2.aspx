<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_003_UpdatePanel.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url(Imagens/fundo.jpg);">
    <form id="form1" runat="server">
    <asp:ScriptManager runat="server" />
    <div>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="DS">
                    <Columns>
                        <asp:BoundField DataField="Codigo" HeaderText="Codigo" SortExpression="Codigo" />
                        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:ObjectDataSource ID="DS" runat="server" SelectMethod="Get" TypeName="_003_UpdatePanel.PessoaDB">
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
