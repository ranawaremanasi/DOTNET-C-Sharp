<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="DBControls.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1"  runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="empno" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="empno" HeaderText="empno" ReadOnly="True" SortExpression="empno" />
                <asp:BoundField DataField="empname" HeaderText="empname" SortExpression="empname" />
                <asp:BoundField DataField="designation" HeaderText="designation" SortExpression="designation" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:BoundField DataField="deptno" HeaderText="deptno" SortExpression="deptno" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDepartmentDBConnectionString %>" SelectCommand="SELECT * FROM [Employee]" InsertCommand="InsertEmployee" InsertCommandType="StoredProcedure" UpdateCommand="UpdateEmployee" UpdateCommandType="StoredProcedure" DeleteCommand="DeleteEmployee" DeleteCommandType="StoredProcedure"></asp:SqlDataSource>
        <asp:FormView ID="FormView1" runat="server" DataKeyNames="empno" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                empno:
                <asp:Label ID="empnoLabel1" runat="server" Text='<%# Eval("empno") %>' />
                <br />
                empname:
                <asp:TextBox ID="empnameTextBox" runat="server" Text='<%# Bind("empname") %>' />
                <br />
                designation:
                <asp:TextBox ID="designationTextBox" runat="server" Text='<%# Bind("designation") %>' />
                <br />
                salary:
                <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                deptno:
                <asp:TextBox ID="deptnoTextBox" runat="server" Text='<%# Bind("deptno") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                empno:
                <asp:TextBox ID="empnoTextBox" runat="server" Text='<%# Bind("empno") %>' />
                <br />
                empname:
                <asp:TextBox ID="empnameTextBox" runat="server" Text='<%# Bind("empname") %>' />
                <br />
                designation:
                <asp:TextBox ID="designationTextBox" runat="server" Text='<%# Bind("designation") %>' />
                <br />
                salary:
                <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                deptno:
                <asp:TextBox ID="deptnoTextBox" runat="server" Text='<%# Bind("deptno") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                empno:
                <asp:Label ID="empnoLabel" runat="server" Text='<%# Eval("empno") %>' />
                <br />
                empname:
                <asp:Label ID="empnameLabel" runat="server" Text='<%# Bind("empname") %>' />
                <br />
                designation:
                <asp:Label ID="designationLabel" runat="server" Text='<%# Bind("designation") %>' />
                <br />
                salary:
                <asp:Label ID="salaryLabel" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                deptno:
                <asp:Label ID="deptnoLabel" runat="server" Text='<%# Bind("deptno") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>