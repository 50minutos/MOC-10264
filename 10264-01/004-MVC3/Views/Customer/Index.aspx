<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<_004_MVC3.Models.Customer>>" %>

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
                NameStyle
            </th>
            <th>
                Title
            </th>
            <th>
                FirstName
            </th>
            <th>
                MiddleName
            </th>
            <th>
                LastName
            </th>
            <th>
                Suffix
            </th>
            <th>
                CompanyName
            </th>
            <th>
                SalesPerson
            </th>
            <th>
                EmailAddress
            </th>
            <th>
                Phone
            </th>
            <th>
                PasswordHash
            </th>
            <th>
                PasswordSalt
            </th>
            <th>
                rowguid
            </th>
            <th>
                ModifiedDate
            </th>
            <th></th>
        </tr>
    
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.NameStyle) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Title) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.FirstName) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.MiddleName) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.LastName) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Suffix) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.CompanyName) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.SalesPerson) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.EmailAddress) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Phone) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PasswordHash) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.PasswordSalt) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.rowguid) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.ModifiedDate) %>
            </td>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.CustomerID }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.CustomerID }) %> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.CustomerID }) %>
            </td>
        </tr>
    <% } %>
    
    </table>
</body>
</html>
