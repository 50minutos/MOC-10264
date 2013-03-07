<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<_004_PartialView.Models.Pessoa>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
</head>
<body>
    <% Html.RenderPartial("Header"); %>
    <table>
        <tr>
            <th>
            </th>
            <th>
                Id
            </th>
            <th>
                Nome
            </th>
            <th>
                SexoId
            </th>
        </tr>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.Id }) %>
                |
                <%: Html.ActionLink("Details", "Details", new { id=item.Id })%>
                |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.Id })%>
            </td>
            <td>
                <%: item.Id %>
            </td>
            <td>
                <%: item.Nome %>
            </td>
            <td>
                <%: item.SexoId %>
            </td>
        </tr>
        <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <% Html.RenderPartial("Footer"); %>
</body>
</html>
