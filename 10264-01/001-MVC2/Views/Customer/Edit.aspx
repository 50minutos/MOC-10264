<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_001_MVC2.Models.Customer>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CustomerID) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CustomerID) %>
                <%: Html.ValidationMessageFor(model => model.CustomerID) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.NameStyle) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.NameStyle) %>
                <%: Html.ValidationMessageFor(model => model.NameStyle) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Title) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Title) %>
                <%: Html.ValidationMessageFor(model => model.Title) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FirstName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.FirstName) %>
                <%: Html.ValidationMessageFor(model => model.FirstName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.MiddleName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.MiddleName) %>
                <%: Html.ValidationMessageFor(model => model.MiddleName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.LastName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.LastName) %>
                <%: Html.ValidationMessageFor(model => model.LastName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Suffix) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Suffix) %>
                <%: Html.ValidationMessageFor(model => model.Suffix) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.CompanyName) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.CompanyName) %>
                <%: Html.ValidationMessageFor(model => model.CompanyName) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.SalesPerson) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.SalesPerson) %>
                <%: Html.ValidationMessageFor(model => model.SalesPerson) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.EmailAddress) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.EmailAddress) %>
                <%: Html.ValidationMessageFor(model => model.EmailAddress) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Phone) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Phone) %>
                <%: Html.ValidationMessageFor(model => model.Phone) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PasswordHash) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.PasswordHash) %>
                <%: Html.ValidationMessageFor(model => model.PasswordHash) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.PasswordSalt) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.PasswordSalt) %>
                <%: Html.ValidationMessageFor(model => model.PasswordSalt) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.rowguid) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.rowguid) %>
                <%: Html.ValidationMessageFor(model => model.rowguid) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.ModifiedDate) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.ModifiedDate, String.Format("{0:g}", Model.ModifiedDate)) %>
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

