<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Site.Models.Categoria>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table  cellspacing="0px">
        <tr>
            <th>
                Cod
            </th>
            <th>
                Descricao
            </th>
            <th></th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: item.Cod %>
            </td>
            <td>
                <%: item.Descricao %>
            </td>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.Cod }) %> |
                <%: Html.ActionLink("Ver", "Details", new { id=item.Cod })%> |
                <%: Html.ActionLink("Excluir", "Delete", new { id=item.Cod })%>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Novo", "Create") %>
    </p>

</asp:Content>

