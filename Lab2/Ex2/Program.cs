namespace Ex2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter the first point");
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        Point point1 = new Point(x1, y1);
        Console.WriteLine("Please enter the second point");
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        Point point2 = new Point(x2, y2);
        Console.WriteLine("We made a rectangle");
        Rectangle rectangle = new Rectangle(point1, point2);
        Console.WriteLine("Please enter the point we want to check");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Point point = new Point(x, y);
        if (rectangle.Check(point))
        {
            Console.WriteLine("The point is in the rectangle.");
        }
        else
        {
            Console.WriteLine("The point is not in the rectangle");
        }
    }
}