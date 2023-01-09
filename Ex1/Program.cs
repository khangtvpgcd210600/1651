namespace Ex1;

class Program
{
    static void Main(string[] args)
    {
        Dice roll = new Dice();

        Console.Write("Enter the number of sides: ");
        int side = int.Parse(Console.ReadLine());
        roll.Side = side;
        Console.WriteLine("The number is: " + roll.Roll());
    }
}