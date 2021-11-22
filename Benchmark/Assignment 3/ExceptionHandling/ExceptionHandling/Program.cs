using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExample
{
    internal class Program
    {
        public void Divide()
        {
            int a, b, res;
            Console.WriteLine("Enter 2 number");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                res = a / b;
                Console.WriteLine("Division = " + res);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Exception Handled" + fe.Message);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Exception Handled " + de.Message);
            }
            catch (Exception ex1)
            {
                throw ex1;
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Divide();
            Console.ReadKey();
        }
    }
}