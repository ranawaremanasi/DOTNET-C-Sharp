namespace AbstractClass
{
    abstract class Animal
    {
        public abstract void Foodhabits();
    }
    class carnivorous : Animal
    {
        public override void Foodhabits()
        {
            Console.WriteLine("meat eating animals");
        }
    }
    class herbivorous : Animal
    {
        public override void Foodhabits()
        {
            Console.WriteLine("plants eating animals");
        }
    }

    class program
    {
        public void CallFun(Animal a)//polymorphic arguments
        {
            if(a.GetType() == typeof(herbivorous))
            {
                herbivorous H = (herbivorous)a;
               
            }
            a.Foodhabits();
        }
        static void Main(string[] args)
        {
            //Animal h=new herbivorous();//runtime polymorphism or dynamic data binding
            //h.Foodhabits();

            herbivorous h = new herbivorous();
            h.Foodhabits();
            Console.WriteLine(h);
            Console.WriteLine(h.ToString());

            carnivorous c= new carnivorous();
            c.Foodhabits();

            program p= new program();
            p.CallFun(h);
            p.CallFun(c);

            Console.ReadKey();
        }
    }
}