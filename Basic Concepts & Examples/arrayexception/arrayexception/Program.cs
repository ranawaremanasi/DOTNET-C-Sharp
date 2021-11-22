using System;

namespace Demo
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = new int[5] { 1,2,3,4,5 };
                int i, j;
                // error: IndexOutOfRangeException
                for (j = 0; j < 10; j++)
                {
                    Console.WriteLine("Element[{0}] = {1}", j, n[j]);
                }
                Console.ReadKey();
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}