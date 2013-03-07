<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_004_MVC3.Models.Customer>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Details</title>
</head>
<body>
    <fieldset>
        <legend>Customer</legend>
    
        <div class="display-label">NameStyle</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.NameStyle) %>
        </div>
    
        <div class="display-label">Title</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Title) %>
        </div>
    
        <div class="display-label">FirstName</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.FirstName) %>
        </div>
    
        <div class="display-label">MiddleName</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.MiddleName) %>
        </div>
    
        <div class="display-label">LastName</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.LastName) %>
        </div>
    
        <div class="display-label">Suffix</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Suffix) %>
        </div>
    
        <div class="display-label">CompanyName</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.CompanyName) %>
        </div>
    
        <div class="display-label">SalesPerson</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.SalesPerson) %>
        </div>
    
        <div class="display-label">EmailAddress</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.EmailAddress) %>
        </div>
    
        <div class="display-label">Phone</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.Phone) %>
        </div>
    
        <div class="display-label">PasswordHash</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PasswordHash) %>
        </div>
    
        <div class="display-label">PasswordSalt</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.PasswordSalt) %>
        </div>
    
        <div class="display-label">rowguid</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.rowguid) %>
        </div>
    
        <div class="display-label">ModifiedDate</div>
        <div class="display-field">
            <%: Html.DisplayFor(model => model.ModifiedDate) %>
        </div>
    </fieldset>
    <p>
    
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.CustomerID }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
</body>
</html>
