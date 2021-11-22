using System;
namespace Arithmeticop
{
    public static class Arithmeticop
    {
        static void Main(string[] args)
        {
            int add,sub,mul,div,a,b,mod;
            Console.WriteLine("Enter 2 nos.");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            add = a + b;
            Console.WriteLine("Addition is:"+add);

            sub= a - b; 
            Console.WriteLine("Subtraction is:"+sub);

            mul = a * b;
            Console.WriteLine("Multiplication is:"+mul);

            mod = a % b;
            Console.WriteLine("Modulo is:" + mod);

            div = a / b;
            Console.WriteLine("Division is:"+div);
            Console.ReadKey();

        }
    }
}

