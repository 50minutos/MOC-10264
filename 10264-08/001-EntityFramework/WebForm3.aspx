<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="_001_EntityFramework.WebForm3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="DS">
           <ItemTemplate>
            <div style="background-color:#fff;">
                <%#Eval("CustomerID", "{0:000000}")%> | 
                <%#Eval("Nome")%> <%#Eval("Sobrenome")%>
            </div>
           </ItemTemplate>
           <AlternatingItemTemplate>
            <div style="background-color:#ccc;">
                <%#Eval("CustomerID", "{0:000000}")%> | 
                <%#Eval("Nome")%> <%#Eval("Sobrenome")%>
            </div>
           </AlternatingItemTemplate>
        </asp:Repeater>
        <asp:EntityDataSource ID="DS" runat="server" 
            ConnectionString="name=AdventureWorksLTEntities" 
            DefaultContainerName="AdventureWorksLTEntities" EnableFlattening="False" 
            EntitySetName="Clientes" Select="it.[Nome], it.[Sobrenome], it.[CustomerID]">
        </asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
