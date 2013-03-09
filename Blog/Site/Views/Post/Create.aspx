<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<Site.Models.Post>" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Create
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create</h2>
    <% using (Html.BeginForm()) {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Fields</legend>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cod) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Cod) %>
            <%: Html.ValidationMessageFor(model => model.Cod) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Titulo) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Titulo) %>
            <%: Html.ValidationMessageFor(model => model.Titulo) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.Conteudo) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.Conteudo) %>
            <%: Html.ValidationMessageFor(model => model.Conteudo) %>
        </div>
        <div class="editor-label">
            <%: Html.LabelFor(model => model.CodUsuario) %>
        </div>
        <div class="editor-field">
            <% Html.RenderPartial("DDLUsuarios"); %>
            <%: Html.ValidationMessageFor(model => model.CodUsuario) %>
        </div>
        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>
</asp:Content>
