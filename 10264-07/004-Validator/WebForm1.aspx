<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_004_Validator.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>
        Exemplo de Validadores</h1>
    <p>
        Digite o seu nome:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" Display="None" ErrorMessage="Preencha o nome" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        Digite o seu e-mail:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" Display="None" ErrorMessage="Preencha o e-mail" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox2" Display="None" 
            ErrorMessage="Digite um e-mail válido" SetFocusOnError="True" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>
        Digite uma senha:<br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox3" Display="None" ErrorMessage="Preencha a senha" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
    </p>
    <p>
        Confirme a senha:<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="TextBox4" Display="None" 
            ErrorMessage="Confirme a senha digitada" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="TextBox3" ControlToValidate="TextBox4" Display="None" 
            ErrorMessage="Digite senhas iguais" SetFocusOnError="True"></asp:CompareValidator>
    </p>
    <p>
        Qual o seu peso (Kg)?<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ControlToValidate="TextBox5" Display="None" 
            ErrorMessage="Digite um número inteiro " Operator="DataTypeCheck" 
            SetFocusOnError="True" Type="Integer"></asp:CompareValidator>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" ShowSummary="False" />
    </form>
</body>
</html>
