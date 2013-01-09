<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_003_MVC3.Models.Pessoa>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Pessoa</legend>
    
        <div class="display-label">Nome</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Nome) %>
        </div>
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
            <input type="submit" value="Delete" /> |
            <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>
    
</body>
</html>
