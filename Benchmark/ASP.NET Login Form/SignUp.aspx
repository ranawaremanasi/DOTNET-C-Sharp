<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApp1.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>  
            <table class="auto-style1">  
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                    </td> 
                    
           <td>
                    <asp:RequiredFieldValidator ID="rfvhouse" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="Enter your name" >
                    </asp:RequiredFieldValidator>
            <br />
         </td>
               </tr>  
                <tr>  
                    <td>Password</td>  
                     <td> <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>  
                </tr>  
               
                <tr>  
                    <td>City</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList1" runat="server">  
                            <asp:ListItem Text="Select City" Value="select" Selected="True"></asp:ListItem>  
                            <asp:ListItem Text="Asansol" Value="Asansol"></asp:ListItem>  
                            <asp:ListItem Text="Kolkata" Value="Kolkata"></asp:ListItem>  
                            <asp:ListItem Text="Pune" Value="Pune"></asp:ListItem>  
                        </asp:DropDownList>  
                    </td> 
                     <td>
                         <asp:RequiredFieldValidator ID="Dsdl" runat="server" 
                             ControlToValidate="DropDownList1" ErrorMessage="Enter your City" >
                        </asp:RequiredFieldValidator>
                            <br />
                      </td>
                </tr>  
                <tr>  
                    <td>Gender</td>  
                    <td>  
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">  
                            <asp:ListItem>Male</asp:ListItem>  
                            <asp:ListItem>Female</asp:ListItem>  
                        </asp:RadioButtonList>  
                    </td>  
                     <td>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                             ControlToValidate="RadioButtonList1" ErrorMessage="Enter your Gender" >
                        </asp:RequiredFieldValidator>
                            <br />
                      </td>
               </tr>  
                <tr>  
                    <td>Gmail</td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>  
                    </td>  
               <td>
                    <asp:RequiredFieldValidator ID="rsdle" runat="server" 
                             ControlToValidate="TextBox4" ErrorMessage="Enter your Gmail" >
                        </asp:RequiredFieldValidator>
             </td>
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="Button1" runat="server" Text="Signup" OnClick="btnsubmit_Click" />  
                    </td>  
                </tr>
                <tr>
                    <td>
                        <p><a href="LoginForm_demo.aspx">Login Page</a></p>
                    </td>
                </tr>
             
                
            </table>  
        </div> 
                        
    </form>
</body>
</html>