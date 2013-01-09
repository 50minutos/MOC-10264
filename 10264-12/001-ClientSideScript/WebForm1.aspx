<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_ClientSideScript.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function mostrarMensagem(s) { window.alert(s); }

        function somar(x, y) { return x + y; }
    </script>
    <script src="Funcoes.js" type="text/javascript"></script>
</head>
<body onload="javascript:mostrarMensagem('opa... carreguei a página...')">
    <form id="form1" runat="server">
    <div>
        <p>
            <input type="button" value="mensagem" onclick="javascript:mostrarMensagem('isso é um alerta');" />
        </p>
        <p>
            <input type="button" value="somar 6 e 7" onclick="javascript:mostrarMensagem(somar(6,7));" />
        </p>
        <p>
            <input type="button" value="mensagem" onclick="javascript:mostrarMensagemNaTela(this, 'tranquilo???');" />
        </p>
    </div>
    </form>
</body>
</html>
