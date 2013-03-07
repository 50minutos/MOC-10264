<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<_001_MVC2.Models.Customer>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                CustomerID
            </th>
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
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.CustomerID }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.CustomerID })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.CustomerID })%>
            </td>
            <td>
                <%: item.CustomerID %>
            </td>
            <td>
                <%: item.NameStyle %>
            </td>
            <td>
                <%: item.Title %>
            </td>
            <td>
                <%: item.FirstName %>
            </td>
            <td>
                <%: item.MiddleName %>
            </td>
            <td>
                <%: item.LastName %>
            </td>
            <td>
                <%: item.Suffix %>
            </td>
            <td>
                <%: item.CompanyName %>
            </td>
            <td>
                <%: item.SalesPerson %>
            </td>
            <td>
                <%: item.EmailAddress %>
            </td>
            <td>
                <%: item.Phone %>
            </td>
            <td>
                <%: item.PasswordHash %>
            </td>
            <td>
                <%: item.PasswordSalt %>
            </td>
            <td>
                <%: item.rowguid %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.ModifiedDate) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</body>
</html>

