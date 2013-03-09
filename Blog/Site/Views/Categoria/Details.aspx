<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<Site.Models.Categoria>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Details</h2>

    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Cod</div>
        <div class="display-field"><%: Model.Cod %></div>
        
        <div class="display-label">Descricao</div>
        <div class="display-field"><%: Model.Descricao %></div>
        
    </fieldset>
    <p>

        <%: Html.ActionLink("Edit", "Edit", new { id=Model.Cod }) %> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</asp:Content>

