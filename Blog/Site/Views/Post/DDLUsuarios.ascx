<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%: Html.DropDownList("CodUsuario", (IEnumerable<SelectListItem>)ViewData["USUARIOS"], "selecione um usuário")%>
