<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Site.Models.Usuario>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Lista de usuários</h2>

    <table cellspacing="0px">
        <tr>
            <th>
                Código
            </th>
            <th>
                Nome
            </th>
            <th>
                Senha
            </th>
            <th>&nbsp;</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.Cod %>
            </td>
            <td>
                <%: item.Nome %>
            </td>
            <td>
                <%: "******" %>
            </td>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.Cod }) %><%: Html.ActionLink("Ver", "Details", new { id=item.Cod })%><%: Html.ActionLink("Excluir", "Delete", new { id=item.Cod })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Novo", "Create") %>
    </p>

</asp:Content>

