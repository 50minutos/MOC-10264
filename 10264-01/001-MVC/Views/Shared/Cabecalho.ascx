<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<p style="text-align: center;">
    <%: Html.ActionLink("Página principal", "Index", "Home") %>
    &nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
    <%: Html.ActionLink("Quem sou eu", "About", "Home") %>
</p>
