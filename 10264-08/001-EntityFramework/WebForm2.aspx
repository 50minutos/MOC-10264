<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_001_EntityFramework.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" AutoGenerateColumns="False" 
            DataSourceID="SqlDS" 
            EmptyDataText="There are no data records to display." 
            DataKeyNames="CustomerID">
            <Columns>
                <asp:BoundField DataField="CustomerID" HeaderText="CustomerID" 
                    InsertVisible="False" ReadOnly="True" SortExpression="CustomerID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                    SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" 
                    SortExpression="LastName" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDS" runat="server" 
            ConnectionString="<%$ ConnectionStrings:AdventureWorksLTConnectionString %>" 
            SelectCommand="SELECT [CustomerID], [FirstName], [LastName] FROM [SalesLT].[Customer] ORDER BY [LastName], [FirstName]">
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
