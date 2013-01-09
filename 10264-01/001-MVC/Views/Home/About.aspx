<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>About</title>
</head>
<body>
    <div>
        <% Html.RenderPartial("Cabecalho"); %>
        
        <h1>
            Esse sou eu!!!</h1>

        <p><%= ViewData["MENSAGEM"].ToString() %></p>

        <% Html.RenderPartial("Rodape"); %>
    </div>
</body>
</html>
