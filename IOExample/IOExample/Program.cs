using System.IO;

namespace IOExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("path");
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\Manasi\\source\\repos\\ExceptionDemo");
            if (di.Exists)
            {
                Console.WriteLine("Name of the Directory : "+di.FullName);
                Console.WriteLine("Creation Time : "+di.CreationTime);
                Console.WriteLine("Parent Directory : "+di.Parent);
                Console.WriteLine("Last Write Time : "+di.LastWriteTime);
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    Console.WriteLine("File name : "+f.FullName);
                    Console.WriteLine("Extension : "+f.Extension);
                    Console.WriteLine("Creation Time : " +f.CreationTime);
                    Console.WriteLine("Length : "+f.Length);
                    Console.WriteLine("_____________________");
                }
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Created");
            }
            Console.ReadKey();
        }
    }
}