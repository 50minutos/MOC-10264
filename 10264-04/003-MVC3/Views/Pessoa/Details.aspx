<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_003_MVC3.Models.Pessoa>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Details</title>
</head>
<body>
    <fieldset>
        <legend>Pessoa</legend>
    
        <div class="display-label">Nome</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Nome) %>
        </div>
    </fieldset>
    <p>
    
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Codigo }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
</body>
</html>
