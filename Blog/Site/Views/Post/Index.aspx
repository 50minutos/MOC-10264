<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Site.Models.Post>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Cod
            </th>
            <th>
                Titulo
            </th>
            <th>
                Conteudo
            </th>
            <th>
                CodUsuario
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.Cod }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.Cod })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.Cod })%>
            </td>
            <td>
                <%: item.Cod %>
            </td>
            <td>
                <%: item.Titulo %>
            </td>
            <td>
                <%: item.Conteudo %>
            </td>
            <td>
                <%: item.CodUsuario %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

