﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Modelo.Master" Inherits="System.Web.Mvc.ViewPage<Site.Models.Categoria>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Cod</div>
        <div class="display-field"><%: Model.Cod %></div>
        
        <div class="display-label">Descricao</div>
        <div class="display-field"><%: Model.Descricao %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

