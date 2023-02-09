namespace Ex2;

class Program
{
    public static void Main(string[] args)
    {
        Exercise1();
        Console.WriteLine();
        Exercise2();
        Console.WriteLine();
        Exercise3();
        Console.WriteLine();
        Exercise4();
        Console.WriteLine();
        Exercise5();
        Console.WriteLine();
        Exercise6();
    }

    public static void Exercise1()
    {
        Console.WriteLine("Please enter the name.");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter the age.");
        int age = int.Parse(Console.ReadLine());
        Child child = new Child(name, age);
        Console.WriteLine(child);
    }

    public static void Exercise2()
    {
        Snake snake = new Snake("Khang");
        Console.WriteLine(snake);
    }

    public static void Exercise3()
    {
        SoulMaster wizard = new SoulMaster("Khang", 100);
        Console.WriteLine(wizard);
    }

    public static void Exercise4()
    {
        SportCar sportCar = new SportCar(2, 1000);
        sportCar.Drive(50);
        Console.Write($"The Fuel of a {sportCar.GetType().Name} after going 50km is ");
        Console.WriteLine(sportCar.Fuel - sportCar.FuelConsumption);
    }

    public static void Exercise5()
    {
        Coffee coffee = new Coffee("Highland", 3);
        Console.WriteLine($"The {coffee.GetType().Name} name {coffee.Name}" +
            $" has the caffeine of {coffee.Caffeine}");
        Cake cake = new Cake("ABC");
        Console.WriteLine($"The {cake.GetType().Name} name {cake.Name} have {cake.Grams} grams," +
            $" {cake.Calories} calories and have a price of {cake.Price}.");
    }

    public static void Exercise6()
    {
        string end = "Beast!";
        string start = Console.ReadLine();
        do
        {
            string[] info = Console.ReadLine().ToString().Split(" ");
            string name = info[0];
            int age = int.Parse(info[1]);
            string gender = info[2];
            switch (start)
            {
                case "Cat":
                    {
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat.GetType().Name);
                        Console.WriteLine($"{cat.Name} {cat.Age} {cat.Gender}");
                        cat.ProduceSound();
                        break;
                    }
                case "Dog":
                    {
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog.GetType().Name);
                        Console.WriteLine($"{dog.Name} {dog.Age} {dog.Gender}");
                        dog.ProduceSound();
                        break;
                    }
                case "Frog":
                    {
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog.GetType().Name);
                        Console.WriteLine($"{frog.Name} {frog.Age} {frog.Gender}");
                        frog.ProduceSound();
                        break;
                    }
                case "Kitten":
                    {
                        Kitten kitten = new Kitten(name, age, gender);
                        Console.WriteLine(kitten.GetType().Name);
                        Console.WriteLine($"{kitten.Name} {kitten.Age} {kitten.Gender}");
                        kitten.ProduceSound();
                        break;
                    }
                case "Tomcat":
                    {
                        Tomcat tomcat = new Tomcat(name, age, gender);
                        Console.WriteLine(tomcat.GetType().Name);
                        Console.WriteLine($"{tomcat.Name} {tomcat.Age} {tomcat.Gender}");
                        tomcat.ProduceSound();
                        break;
                    }
                default: break;
            }
            start = Console.ReadLine();
        } while (start != end);
    }
}