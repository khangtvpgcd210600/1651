namespace Ex1;

class Program
{
    public static void Main(string[] args)
    {
        Exercise1();
        Exercise2();
        Exercise3();
    }

    public static void Exercise1()
    {
        MathOperations mo = new MathOperations();
        Console.WriteLine(mo.Add(2, 3));
        Console.WriteLine(mo.Add(2.2, 3.3, 5.5));
        Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m));
    }

    public static void Exercise2()
    {
        Animal cat = new Cat("Pesho", "Whiskas");
        Animal dog = new Dog("Gosho", "Meat");
        Console.WriteLine(cat.ExplainSelf());
        Console.WriteLine(dog.ExplainSelf());
    }

    public static void Exercise3()
    {
        Shape shape1 = new Rectangle(3, 4);
        Console.WriteLine(shape1.Draw());
        Shape shape2 = new Circle(3);
        Console.WriteLine(shape2.Draw());
    }
}
