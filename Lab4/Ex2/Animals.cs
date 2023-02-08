namespace Ex2;

internal class Animals
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Animals(string name, int age, string gender)
    {
        if (name.Length < 1) throw new ArgumentException("Invalid input");
        else Name = name;
        if (age < 1) throw new ArgumentException("Invalid input");
        else Age = age;
        if (gender == "Male" || gender == "Female")
            Gender = gender;
        else throw new ArgumentException("Invalid input");
    }

    public virtual void ProduceSound()
    {

    }
}

internal class Dog : Animals
{
    public Dog(string name, int age, string gender) : base(name, age, gender) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
}

internal class Cat : Animals
{
    public Cat(string name, int age, string gender) : base(name, age, gender) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow meow");
    }
}

internal class Frog : Animals
{
    public Frog(string name, int age, string gender) : base(name, age, gender) { }

    public override void ProduceSound()
    {
        Console.WriteLine("Ribbit");
    }
}

internal class Kitten : Cat
{
    public Kitten(string name, int age, string gender) : base(name, age, gender)
    {
        Gender = "Female";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }
}

internal class Tomcat : Cat
{
    public Tomcat(string name, int age, string gender) : base(name, age, gender)
    {
        Gender = "Male";
    }

    public override void ProduceSound()
    {
        Console.WriteLine("MEOW");
    }
}
