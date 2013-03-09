<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<Site.Models.Post>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Edit</h2>

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
                <%: Html.TextBoxFor(model => model.CodUsuario) %>
                <%: Html.ValidationMessageFor(model => model.CodUsuario) %>
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

