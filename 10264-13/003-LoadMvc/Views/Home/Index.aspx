<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
    <script src="../../Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
</head>
<body>
    <div>
        <span id="topo"></span>
        
        <p>esse é o conteúdo da página</p>
        
        <span id="rodape"></span>
        
        <script type="text/javascript">
            $("#topo").load("/Header.htm");
            $("#rodape").load("/Footer.htm");
        </script>
    </div>
</body>
</html>
