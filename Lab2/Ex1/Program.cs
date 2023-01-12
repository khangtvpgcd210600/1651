namespace Ex1;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the size of the rhombus");
        int size = int.Parse(Console.ReadLine());
        Rhombus rhombus = new Rhombus(size);
        rhombus.Print();
    }
}