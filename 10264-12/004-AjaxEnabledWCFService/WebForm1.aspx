<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_004_AjaxEnabledWCFService.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function somar(x, y) {
            Calculadora.Somar(x, y, onSuccess, null, null);
        }

        function onSuccess(result) {
            alert(result);
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        <Services>
            <asp:ServiceReference Path="~/Calculadora.svc" />
        </Services>
    </asp:ScriptManager>
    <div>
        <p>
            <input type="button" value="clique aqui" onclick="javascript:somar(20, 30);" /></p>
    </div>
    </form>
</body>
</html>
