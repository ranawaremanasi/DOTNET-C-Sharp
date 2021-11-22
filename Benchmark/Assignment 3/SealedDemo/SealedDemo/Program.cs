namespace SealedDemo
{
    class Parent
    {
        public virtual void Demo()
        {
            Console.WriteLine("Parent Demo");
        }
    }
    class Child : Parent
    {
        public sealed override void Demo()
        {
            Console.WriteLine("Child Demo");
        }
    }
    class GrandChild : Child
    {
        //public override void Demo()
        //{
        //    Console.WriteLine("GrandChild Demo");
        //}
        
    }

class program
{
    static void Main(string[] args)
    {
        Parent p=new Parent();
            p.Demo();
            Console.WriteLine("this is parent");
            Console.ReadKey();
    }
}
}