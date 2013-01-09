<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm01.aspx.cs" Inherits="_10264_13.WebForm01" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(ConteudoDinamico).hide();
            $("#Botao").click(LerPagina);
        });

        function LerPagina() {
            $("#ConteudoDinamico")
                .load("WebForm01a.aspx",
                { nome: $("#Nome").val() },
                function (content) {
                    $(this).hide().fadeIn("slow");
                    return false;
                });
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Nome:<br />
        <asp:TextBox runat="server" ID="Nome" />
        <input type="button" id="Botao" value="Ler conteúdo do WebForm01a.aspx" />
        <div id="ConteudoDinamico">
        </div>
    </div>
    </form>
</body>
</html>
