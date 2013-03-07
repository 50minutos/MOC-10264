<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_004_MVC3.Models.Customer>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Edit</title>
</head>
<body>
    <script src="<%: Url.Content("~/Scripts/jquery-1.5.1.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
    
    <% using (Html.BeginForm()) { %>
        <%: Html.ValidationSummary(true) %>
        <fieldset>
            <legend>Customer</legend>
    
            <%: Html.HiddenFor(model => model.CustomerID) %>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NameStyle) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.NameStyle) %>
                <%: Html.ValidationMessageFor(model => model.NameStyle) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FirstName) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.FirstName) %>
                <%: Html.ValidationMessageFor(model => model.FirstName) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.MiddleName) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.MiddleName) %>
                <%: Html.ValidationMessageFor(model => model.MiddleName) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LastName) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.LastName) %>
                <%: Html.ValidationMessageFor(model => model.LastName) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Suffix) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Suffix) %>
                <%: Html.ValidationMessageFor(model => model.Suffix) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CompanyName) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.CompanyName) %>
                <%: Html.ValidationMessageFor(model => model.CompanyName) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.SalesPerson) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.SalesPerson) %>
                <%: Html.ValidationMessageFor(model => model.SalesPerson) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.EmailAddress) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.EmailAddress) %>
                <%: Html.ValidationMessageFor(model => model.EmailAddress) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Phone) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.Phone) %>
                <%: Html.ValidationMessageFor(model => model.Phone) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PasswordHash) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.PasswordHash) %>
                <%: Html.ValidationMessageFor(model => model.PasswordHash) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PasswordSalt) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.PasswordSalt) %>
                <%: Html.ValidationMessageFor(model => model.PasswordSalt) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.rowguid) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.rowguid) %>
                <%: Html.ValidationMessageFor(model => model.rowguid) %>
            </div>
    
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ModifiedDate) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.ModifiedDate) %>
                <%: Html.ValidationMessageFor(model => model.ModifiedDate) %>
            </div>
    
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>
    <% } %>
    
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</body>
</html>
