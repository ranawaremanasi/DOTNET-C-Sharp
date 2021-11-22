//Use DirectoryInfo and FileInfo class and print details of directories and files available in that directory
//IOExample

using System.IO;

namespace IOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Directory.CreateDirectory("path");
                DirectoryInfo di = new DirectoryInfo("C:\\Users\\Manasi\\source\\repos");
                if (di.Exists)
                {
                    Console.WriteLine(di.FullName);
                    Console.WriteLine(di.CreationTime);
                    Console.WriteLine(di.Parent);
                    Console.WriteLine(di.LastWriteTime);
                    FileInfo[] fi = di.GetFiles();
                    foreach (FileInfo f in fi)
                    {
                        Console.WriteLine(f.FullName);
                        Console.WriteLine(f.Extension);
                        Console.WriteLine(f.CreationTime);
                        Console.WriteLine(f.Length);
                        Console.WriteLine("_____________________");
                    }
                }
                else
                {
                    di.Create();
                    Console.WriteLine("Directory Created");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: "+ex.Message);
            }
            Console.ReadKey();
        }
    }
}