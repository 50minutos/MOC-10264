﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
</head>
<body>
    <div>
        <% Html.RenderPartial("Cabecalho"); %>

        <h1>
            Opa... blz?</h1>

        <% Html.RenderPartial("Rodape"); %>
    </div>
</body>
</html>