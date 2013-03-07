<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_001_MVC2.Models.Customer>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">CustomerID</div>
        <div class="display-field"><%: Model.CustomerID %></div>
        
        <div class="display-label">NameStyle</div>
        <div class="display-field"><%: Model.NameStyle %></div>
        
        <div class="display-label">Title</div>
        <div class="display-field"><%: Model.Title %></div>
        
        <div class="display-label">FirstName</div>
        <div class="display-field"><%: Model.FirstName %></div>
        
        <div class="display-label">MiddleName</div>
        <div class="display-field"><%: Model.MiddleName %></div>
        
        <div class="display-label">LastName</div>
        <div class="display-field"><%: Model.LastName %></div>
        
        <div class="display-label">Suffix</div>
        <div class="display-field"><%: Model.Suffix %></div>
        
        <div class="display-label">CompanyName</div>
        <div class="display-field"><%: Model.CompanyName %></div>
        
        <div class="display-label">SalesPerson</div>
        <div class="display-field"><%: Model.SalesPerson %></div>
        
        <div class="display-label">EmailAddress</div>
        <div class="display-field"><%: Model.EmailAddress %></div>
        
        <div class="display-label">Phone</div>
        <div class="display-field"><%: Model.Phone %></div>
        
        <div class="display-label">PasswordHash</div>
        <div class="display-field"><%: Model.PasswordHash %></div>
        
        <div class="display-label">PasswordSalt</div>
        <div class="display-field"><%: Model.PasswordSalt %></div>
        
        <div class="display-label">rowguid</div>
        <div class="display-field"><%: Model.rowguid %></div>
        
        <div class="display-label">ModifiedDate</div>
        <div class="display-field"><%: String.Format("{0:g}", Model.ModifiedDate) %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</body>
</html>

