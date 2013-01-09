<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_001_EntityFramework.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" DataSourceID="EDS" 
            DataKeyNames="CustomerID">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" ReadOnly="True" 
                    SortExpression="CustomerID" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" ReadOnly="True" 
                    SortExpression="Nome" />
                <asp:BoundField DataField="Sobrenome" HeaderText="Sobrenome" ReadOnly="True" 
                    SortExpression="Sobrenome" />
            </Columns>
        </asp:GridView>
        <asp:EntityDataSource ID="EDS" runat="server" 
            ConnectionString="name=AdventureWorksLTEntities" 
            DefaultContainerName="AdventureWorksLTEntities" EnableFlattening="False" 
            EntitySetName="Clientes" OrderBy="it.[CustomerID]" 
            Select="it.[CustomerID], it.[Nome], it.[Sobrenome]">
        </asp:EntityDataSource>
    
    </div>
    </form>
</body>
</html>
