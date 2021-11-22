using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOutOfBound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5, 6 };
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}