using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Server=.;Database=EmployeeDB;trusted_connection=true";
            con.Open();

            //SqlCommand cmd = new SqlCommand("Insert_Department", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            SqlTransaction tran = null;
            try
            {
                tran = con.BeginTransaction();
                SqlCommand cmd = new SqlCommand("Insert_Department", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tran;
                cmd.Parameters.AddWithValue("deptno", 100);
                cmd.Parameters.AddWithValue("deptnamee", "Logistic");
                cmd.Parameters.AddWithValue("joindate", "2-2-21");
                

                cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("Insert_Department", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Transaction = tran;
                cmd1.Parameters.AddWithValue("deptno", 90);
                cmd1.Parameters.AddWithValue("deptname", "Admin ");
                cmd1.Parameters.AddWithValue("joindate", "3-3-21");
         
                cmd1.ExecuteNonQuery();
                tran.Commit();
                Console.WriteLine("Transaction completed successfully");
            }
            catch (SqlException ex)
            {
                tran.Rollback();
                Console.WriteLine("Transaction rolled back");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                Console.WriteLine("Transaction rolled back");
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
    }
}