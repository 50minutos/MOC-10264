<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SM.ascx.cs" Inherits="_005_LoginAjax.SM" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
    <Services>
        <asp:ServiceReference Path="~/Seguranca.svc" />
    </Services>
</asp:ScriptManager>
