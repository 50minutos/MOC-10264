<%@ Page Title="" Language="C#" MasterPageFile="~/Modelo.Master" AutoEventWireup="true" CodeBehind="AlterarSenha.aspx.cs" Inherits="_001_Login.Restrito.AlterarSenha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#E3EAEB" 
        BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" 
        ContinueDestinationPageUrl="~/WebForm1.aspx" Font-Names="Verdana" 
        Font-Size="0.8em">
        <CancelButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" 
            BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
        <ChangePasswordButtonStyle BackColor="White" BorderColor="#C5BBAF" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#1C5E55" />
        <ContinueButtonStyle BackColor="White" BorderColor="#C5BBAF" 
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
            ForeColor="#1C5E55" />
        <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
        <PasswordHintStyle Font-Italic="True" ForeColor="#1C5E55" />
        <TextBoxStyle Font-Size="0.8em" />
        <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" 
            ForeColor="White" />
    </asp:ChangePassword>
</asp:Content>
