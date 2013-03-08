<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<Site.Models.Usuario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Details</h2>
    <fieldset>
        <legend>Fields</legend>
        <div class="display-label">
            <%: Html.LabelFor(model => model.Cod) %>
        </div>
        <div class="display-field">
            <%: Model.Cod %></div>
        <div class="display-label">
            Nome</div>
        <div class="display-field">
            <%: Model.Nome %></div>
        <div class="display-label">
            Senha</div>
        <div class="display-field">
            <%: Model.Senha %></div>
    </fieldset>
    <p>
        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Cod }) %>
        |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
</asp:Content>
