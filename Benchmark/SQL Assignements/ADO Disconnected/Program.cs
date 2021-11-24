using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADODisconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char ch;
                int choice;
                SqlConnection conn = new SqlConnection("Server=.;Database=StudentDB;trusted_connection=true");
                SqlCommand cmd = new SqlCommand("Select * from Course", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Course");
                DataTable tab = ds.Tables["Course"];
                //Fill - method fetched data from database and stores to dataset
                //update- changes done into dataset are made permanent with the help of update method

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Menu\n");
                    Console.WriteLine("1. Print All Courses");
                    Console.WriteLine("2. Print Specific Course");
                    Console.WriteLine("3. Insert Course");
                    Console.WriteLine("4. Update Course");
                    Console.WriteLine("5. Delete Course");

                    Console.Write("Enter your choice:");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            foreach (DataRow row in tab.Rows)
                            {
                                Console.WriteLine(row[0] + "\t" + row[1] + "\t" + row[2] + "\t" + row[3]);
                            }
                            break;

                        case 2:
                            Console.WriteLine("Enter Course ID");
                            int cid = Convert.ToInt32(Console.ReadLine());
                            DataRow[] rows = tab.Select("cid= " + cid);
                            Console.WriteLine("Course Details are");
                            foreach (DataRow row in rows)
                            {
                                Console.WriteLine(row[0].ToString() + "\t" + row[1].ToString() + "\t" + row[2].ToString() + "\t" + row[3].ToString());
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter Course ID");
                            int cid1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Course Name");
                            string cname = Console.ReadLine();
                            Console.WriteLine("Enter Instructor");
                            string instructor = Console.ReadLine();
                            Console.WriteLine("Enter Course Fees");
                            int fees = Convert.ToInt32(Console.ReadLine());

                            DataRow NewRow = tab.NewRow();
                            NewRow["cid"] = cid1;
                            NewRow["cname"] = cname;
                            NewRow["instructor"] = instructor;
                            NewRow["fees"] = fees;

                            tab.Rows.Add(NewRow);
                            adapter.Update(tab); //Data will be inserted
                            Console.WriteLine("Record Inserted Successfully");

                            break;

                        case 4:
                            Console.WriteLine("Enter Course ID");
                            int cid2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Course Name");
                            string cname2 = Console.ReadLine();
                            Console.WriteLine("Enter Instructor");
                            string instructor2 = Console.ReadLine();
                            Console.WriteLine("Enter Course Fees");
                            int fees2 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] UpdateRow = tab.Select("cid= " + cid2);
                            DataRow rowup = UpdateRow[0];
                            rowup["cname"] = cname2;
                            rowup["instructor"] = instructor2;
                            rowup["fees"] = fees2;
                            adapter.Update(tab); //Data will be inserted
                            Console.WriteLine("Record Updated Successfully");

                            break;

                        case 5:
                            Console.WriteLine("Enter Course ID");
                            int cid3 = Convert.ToInt32(Console.ReadLine());

                            DataRow[] rod = tab.Select("cid= " + cid3);
                            DataRow rowDelete = rod[0];

                            rowDelete.Delete();

                            adapter.Update(ds, "Course");

                            Console.WriteLine("Record Deleted Successfully");
                            break;

                        default:
                            Console.WriteLine("Invalid Case");
                            break;
                    }

                    Console.WriteLine("Select Y or y to continue");
                    ch = Convert.ToChar(Console.ReadLine());
                }
                while (ch == 'Y' || ch == 'y');

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}