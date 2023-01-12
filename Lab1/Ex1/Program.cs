namespace Ex1;

class Program
{
    static void Main(string[] args)
    {
        Dice roll = new Dice();

        Console.Write("Enter the number of sides: ");
        int side = int.Parse(Console.ReadLine());
        roll.Side = side;
        int trueNumber = roll.Roll();
        while (true)
        {
            Console.WriteLine("Please guess a number");
            int guessNumber = int.Parse(Console.ReadLine());
            if (guessNumber == trueNumber)
            {
                Console.WriteLine("You've guess the right number!");
                break;
            }
            else
            {
                Console.WriteLine("You've guess the wrong number!");
                Console.WriteLine("Press n to end the program or you can try again!");
                char character = char.Parse(Console.ReadLine());
                if (character == 'n')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
        }


    }
}