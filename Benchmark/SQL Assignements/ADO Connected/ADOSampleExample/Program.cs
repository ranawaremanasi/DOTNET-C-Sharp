using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Data.SqlClient;



namespace ADOSampleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection();
                con.ConnectionString = "Server =.;Database=EmployeeDB;trusted_connection=true";
                con.Open();

                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandType = CommandType.StoredProcedure;


                // or 
                SqlCommand cmd = new SqlCommand("Get_EmployeeData",con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString() + "\t" +
                        reader["ename"].ToString() + "\t" +
                        reader[2].ToString() + "\t" +
                        reader[3].ToString() + "\t" +
                        reader[4].ToString() + "\t"
                        );
                }
                Console.ReadKey();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
                Console.WriteLine("");
            }
        }
    }
}