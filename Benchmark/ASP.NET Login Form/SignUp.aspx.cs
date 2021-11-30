using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApp1
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Database=EmployeeDB;trusted_connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Signup_demo values(@Name, @Password, @City, @Gender, @Mail)", con);
            cmd.Parameters.AddWithValue("Name", TextBox1.Text);
            cmd.Parameters.AddWithValue("Password", TextBox2.Text);
            cmd.Parameters.AddWithValue("City", DropDownList1.SelectedValue);
            cmd.Parameters.AddWithValue("Gender", RadioButtonList1.SelectedValue);
            cmd.Parameters.AddWithValue("Mail", TextBox4.Text);
            cmd.ExecuteNonQuery();

            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList1.SelectedValue = "";
            RadioButtonList1.SelectedValue = "";
            TextBox4.Text = "";
            TextBox1.Focus();

            con.Close();



        }

    }
}