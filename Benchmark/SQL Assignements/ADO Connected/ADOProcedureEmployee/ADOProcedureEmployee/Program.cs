using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOProcedureExployee
{
    class EmployeeDal
    {
        public SqlDataReader GetEmployeeData()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Server =.; Database= EmployeeDB; trusted_connection=true";
                conn.Open();

                SqlCommand cmd = new SqlCommand("Get_EmployeeData", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }

        public SqlDataReader GetEmpUsingEmpno(int eno)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Server =.; Database= EmployeeDB; trusted_connection=true";
                conn.Open();

                SqlCommand cmd = new SqlCommand("GetEmpUsingEmpno", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("eno", eno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }
        public int InsertEmployee(int eno, string ename, string designation, float salary, int deptno)
        {
            SqlConnection conn = null;
            int res = 0;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Server =.; Database= EmployeeDB; trusted_connection=true";
                conn.Open();

                SqlCommand cmd = new SqlCommand("InsertEmployee", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("eno", eno);
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter("ename", ename);
                SqlParameter param3 = new SqlParameter("designation", designation);
                SqlParameter param4 = new SqlParameter("salary", salary);
                SqlParameter param5 = new SqlParameter("deptno", deptno);

                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);

                res = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return res;
        }
        public int UpdateEmployee(int eno, string ename, string designation, float salary, int deptno)
        {
            SqlConnection conn = null;
            int res = 0;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Server =.; Database= EmployeeDB; trusted_connection=true";
                conn.Open();

                SqlCommand cmd = new SqlCommand("UpdateEmployee", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("eno", eno);
                cmd.Parameters.Add(param);

                SqlParameter param2 = new SqlParameter("ename", ename);
                SqlParameter param3 = new SqlParameter("designation", designation);
                SqlParameter param4 = new SqlParameter("salary", salary);
                SqlParameter param5 = new SqlParameter("deptno", deptno);

                cmd.Parameters.Add(param2);
                cmd.Parameters.Add(param3);
                cmd.Parameters.Add(param4);
                cmd.Parameters.Add(param5);

                res = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return res;
        }

        public SqlDataReader DeleteUsingEmpno(int eno)
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;

            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = "Server =.; Database= EmployeeDB; trusted_connection=true";
                conn.Open();

                SqlCommand cmd = new SqlCommand("DeleteUsingEmpno", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("eno", eno);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reader;
        }
        //public int DeleteEmployee(int eno)
        //{
        //    SqlConnection conn = null;
        //    int res = 0;

        //    try
        //    {
        //        conn = new SqlConnection();
        //        conn.ConnectionString = "Server =.; Database= EmployeeDB; trusted_connection=true";
        //        conn.Open();

        //        SqlCommand cmd = new SqlCommand("DeleteEmployee", conn);
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //        SqlParameter param = new SqlParameter("eno", eno);
        //        cmd.Parameters.Add(param);



        //        res = cmd.ExecuteNonQuery();

        //    }
        //    catch (SqlException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return res;
        //}
        public void PrintData(SqlDataReader reader)
        {
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + "\t" + reader[1].ToString() + "\t" + reader[2].ToString() + "\t" + reader[3].ToString() + "\t" + reader[4].ToString() + "\t");

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDal emp = new EmployeeDal();
            int choice;
            char ch;
            do
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Get Employee Details");
                Console.WriteLine("2. Get specific Employee Details(Based on Employee number)");
                Console.WriteLine("3. Insert Employee");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Delete Employee Based on Employee number");
                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        emp.PrintData(emp.GetEmployeeData());
                        break;

                    case 2:
                        Console.WriteLine("Enter Employee number");
                        int empno = Convert.ToInt32(Console.ReadLine());
                        emp.PrintData(emp.GetEmpUsingEmpno(empno));
                        break;

                    case 3:
                        Console.WriteLine("Enter Employee number");
                        int eno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee name");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Enter Employee designation");
                        string desig = Console.ReadLine();
                        Console.WriteLine("Enter Employee salary");
                        int sal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department no");
                        int depno = Convert.ToInt32(Console.ReadLine());
                        emp.InsertEmployee(eno, ename, desig, sal, depno);
                        Console.WriteLine("Data inserted Successful");
                        break;

                    case 4:
                        Console.WriteLine("Enter Employee number");
                        int eno1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee name");
                        string ename1 = Console.ReadLine();
                        Console.WriteLine("Enter Employee designation");
                        string desig1 = Console.ReadLine();
                        Console.WriteLine("Enter Employee salary");
                        int sal1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Department no");
                        int depno1 = Convert.ToInt32(Console.ReadLine());
                        emp.UpdateEmployee(eno1, ename1, desig1, sal1, depno1);
                        Console.WriteLine("Data Updated Successful");
                        break;

                    case 5:
                        Console.WriteLine("Enter Employee number");
                        int empno1 = Convert.ToInt32(Console.ReadLine());
                        emp.DeleteUsingEmpno(empno1);
                        Console.WriteLine("Data Deleted Successful");
                        break;

                    default:
                        Console.WriteLine("Invalid Case");
                        break;
                }
                Console.WriteLine("Enter Y or y to continue");
                ch = Convert.ToChar(Console.ReadLine());
            }
            while (ch == 'Y' || ch == 'y');
            Console.ReadLine();
        }
    }
}