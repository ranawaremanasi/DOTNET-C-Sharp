//Create user defined generic class containing generic method swap. Use it for different datatypes and verify in main

using System;
using System.Collections.Generic;

namespace GenericApp
{
    class Program
    {
        //Generic method
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            // Swap 
            int a = 32, b = 23;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);

            //string a = "food", b = "salad";
            //Console.WriteLine("Before swap: {0}, {1}", a, b);
            //Swap<string>(ref a, ref b);
            //Console.WriteLine("After swap: {0}, {1}", a, b);

            //bool a=true, b=false;
            //Console.WriteLine("Before swap: {0}, {1}", a, b);
            //Swap<bool>(ref a, ref b);
            //Console.WriteLine("After swap: {0}, {1}", a, b);

            Console.ReadLine();
        }
    }
}