using Ex3;

class Program
{
    static void Main(string[] args)
    {
        Exercise1();
        Console.WriteLine();
        Exercise2();
        Console.WriteLine();
        Exercise3();
        Console.WriteLine();
        Exercise4();

    }
    public static void Exercise1()
    {
        Console.WriteLine("Exercise 1");
        Dice roll = new Dice();

        Console.Write("Enter the number of sides: ");
        int side = int.Parse(Console.ReadLine());
        roll.Side = side;
        int trueNumber = roll.Roll();
        Console.WriteLine("Please guess a number");
        int guessNumber = int.Parse(Console.ReadLine());
        if (guessNumber == trueNumber)
        {
            Console.WriteLine("You've guess the right number!");
        }
        else
        {
            Console.WriteLine("You've guess the wrong number!");
            Console.WriteLine($"The true number is {trueNumber}");
        }
    }

    public static void Exercise2()
    {
        Console.WriteLine("Exercise 2");
        Person person = new Person();
        person.Name = "Test";
        person.Age = 1;
        person.DisplayPerson();

        Student student = new Student();
        student.Name = person.Name;
        student.Age = person.Age;
        student.Gpa = 3.0f;
        student.DisplayStudent();
    }

    public static void Exercise3()
    {
        Console.WriteLine("Exercise 3");
        int numberofSongs = int.Parse(Console.ReadLine());
        Song[] songs = new Song[numberofSongs];
        for (int i = 0; i < numberofSongs; i++)
        {
            string[] data = Console.ReadLine().Split("_");
            songs[i] = new Song();
            songs[i].TypeList = data[0];
            songs[i].Name = data[1];
            songs[i].Time = data[2];
        }
        string typeList = Console.ReadLine();
        if (typeList == "all")
        {
            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
        else
        {
            foreach (Song song in songs)
            {
                if (song.TypeList == typeList)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public static void Exercise4()
    {
        Console.WriteLine("Exercise 4");
        Fraction fraction1 = new Fraction(int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()));
        Fraction fraction2 = new Fraction(int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()));
        Console.Write("Add: "); fraction1.Add(fraction2);
        Console.Write("Subtract: "); fraction1.Subtract(fraction2);
        Console.Write("Mulitply: "); fraction1.Multiply(fraction2);
        Console.Write("Divide: "); fraction1.Divide(fraction2);
        Console.Write("Fraction 1: "); fraction1.DisplayFraction();
        Console.Write("Fraction 2: "); fraction2.DisplayFraction();
        Console.Write("Fraction 1 in decimal: "); fraction1.DisplayFractionInDecimal();
        Console.Write("Fraction 2 in decimal: "); fraction2.DisplayFractionInDecimal();
    }
}