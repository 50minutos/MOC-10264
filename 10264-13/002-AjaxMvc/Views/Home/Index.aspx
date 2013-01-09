<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript" src="<%=Url.Content("~/Scripts/MicrosoftAjax.debug.js")%>" ></script>
    <script type="text/javascript" src="<%=Url.Content("~/Scripts/MicrosoftMvcAjax.debug.js")%>" ></script>
    <title>Index</title>
</head>
<body>
    <div>
        <h1>:: ActionLink ::</h1>
        <p>
            <%= Ajax.ActionLink("Enviar", "ObterData", new AjaxOptions{ UpdateTargetId="Data" }) %>
        </p>
        <p>
            <span id="Data">...</span></p>
    </div>
</body>
</html>
