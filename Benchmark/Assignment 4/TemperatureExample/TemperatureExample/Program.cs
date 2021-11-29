using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureLibrary;
using TemperatureCalculator;


namespace TemperatureLibrary
{
   public class Program
    {
        static void Main(string[] args)
        {
            TemperatureCalculator.Class1 temp1 = new TemperatureCalculator.Class1();
            Console.WriteLine(temp1.FehernheitToCelsius(76));
            Console.ReadKey();
        }
    }
}