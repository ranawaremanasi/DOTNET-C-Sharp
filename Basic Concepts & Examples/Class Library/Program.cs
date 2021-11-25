using MathClassLibrary;
namespace ClassLibUser
{
    class Pragram
    {
        static void Main(string[] args)
        {
            MathClassLibrary.MathClass obj = new MathClassLibrary.MathClass();
            Console.WriteLine(obj.add(4, 5));
            Console.WriteLine(obj.sub(4, 5));
            Console.WriteLine(obj.mul(4, 5));
            Console.WriteLine(obj.div(4, 5));
            Console.ReadKey();
        }
    }
}