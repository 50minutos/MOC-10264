<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<_003_MVC3.Models.Pessoa>>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Index</title>
</head>
<body>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <table>
        <tr>
            <th>
                Nome
            </th>
            <th></th>
        </tr>
    
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.Nome) %>
            </td>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.Codigo }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.Codigo }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.Codigo }) %>
            </td>
        </tr>
    <% } %>
    
    </table>
</body>
</html>
