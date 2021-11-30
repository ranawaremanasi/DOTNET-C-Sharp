<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MasterDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
                <asp:SqlDataSource runat="server" ID="a"  ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" SelectCommand="SELECT * FROM [employee]"></asp:SqlDataSource>
               
                <asp:Repeater ID="Repeater1" runat="server" DataSourceID="a">
            <HeaderTemplate>Employee Details
                <br />
                <table border="1">
                    <thead>
                        <th>EmployeeNo</th>
                        <th>EmployeeName</th>
                        <th>EmployeeDesignation</th>
                        <th>Salary</th>
                        <th>DepartmentNo</th>
                    </thead>
              
            </HeaderTemplate>
                <ItemTemplate>
                    <tr style="background-color:red">
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%#Bind("eno")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label2" runat="server" Text='<%#Bind("ename")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label3" runat="server" Text='<%#Bind("designation")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label4" runat="server" Text='<%#Bind("salary")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label5" runat="server" Text='<%#Bind("deptno")%>'></asp:Label>
                        </td>
                    </tr>
                </ItemTemplate>
                <AlternatingItemTemplate>
                    <tr style="background-color:aqua">
                        <td>
                            <asp:Label ID="Label6" runat="server" Text='<%#Bind("eno")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label7" runat="server" Text='<%#Bind("ename")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label8" runat="server" Text='<%#Bind("designation")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label9" runat="server" Text='<%#Bind("salary")%>'></asp:Label></td>
                           <td> <asp:Label ID="Label10" runat="server" Text='<%#Bind("deptno")%>'></asp:Label>
                        </td>
                    </tr>
                </AlternatingItemTemplate>
            <FooterTemplate>
                <td colspan="4">
                    </table>
                </td>
                
            </FooterTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
